using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProgrammingDemo9
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        int currentRecord = 0;
        int currentProductId = 0;
        int firstProductId = 0;
        int lastProductId = 0;
        int? previousProductId;
        int? nextProductId;

        #region [Form Events]

        /// <summary>
        /// Form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadCategories();
        }

        /// <summary>
        /// Add buton click event handler. Places the form in a creation mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cancel any changes to an existin selected product or the beginnings of the newly created product
        /// We will reload the last active product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Delete button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region [Retrieves]
        
        /// <summary>
        /// Load the Suppliers and bind the combobox
        /// </summary>
        private void LoadSuppliers()
        {
            string sqlSuppliers = "SELECT SupplierId, CompanyName FROM Suppliers ORDER BY CompanyName";

            UIUtilities.BindComboBox(cmbSuppliers, DataAccess.GetData(sqlSuppliers), "CompanyName", "SupplierId");
        }

        /// <summary>
        /// Load the Categories and bind the ComboBox
        /// </summary>
        private void LoadCategories()
        {
            UIUtilities.BindComboBox(cmbCategories, DataAccess.GetData("SELECT CategoryId, CategoryName FROM Categories ORDER BY CategoryName"), "CategoryName", "CategoryId");
        }

        /// <summary>
        /// Load the product details into the form when using navigation buttons
        /// </summary>
        private void LoadProductDetails()
        {
            //Clear any errors in the error provider
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Products WHERE ProductId = {currentProductId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) ProductId as FirstProductId FROM Products ORDER BY ProductName
                ) as FirstProductId,
                q.PreviousProductId,
                q.NextProductId,
                (
                    SELECT TOP(1) ProductId as LastProductId FROM Products ORDER BY ProductName Desc
                ) as LastProductId,
                q.RowNumber
                FROM
                (
                    SELECT ProductId, ProductName,
                    LEAD(ProductId) OVER(ORDER BY ProductName) AS NextProductId,
                    LAG(ProductId) OVER(ORDER BY ProductName) AS PreviousProductId,
                    ROW_NUMBER() OVER(ORDER BY ProductName) AS 'RowNumber'
                    FROM Products
                ) AS q
                WHERE q.ProductId = {currentProductId}
                ORDER BY q.ProductName".Replace(System.Environment.NewLine," "),
                "SELECT COUNT(ProductId) as ProductCount FROM Products"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            DataRow selectedProduct = ds.Tables[0].Rows[0];
            
            cmbSuppliers.SelectedValue = selectedProduct["SupplierId"];
            cmbCategories.SelectedValue = selectedProduct["CategoryId"];
            txtProductName.Text = selectedProduct["ProductName"].ToString();
            txtQtyPerUnit.Text = selectedProduct["QuantityPerUnit"].ToString();
            txtUnitPrice.Text = Convert.ToDouble(selectedProduct["UnitPrice"]).ToString("n2");
            txtStock.Text = selectedProduct["UnitsInStock"].ToString();
            txtOnOrder.Text = selectedProduct["UnitsOnOrder"].ToString();
            txtReorder.Text = selectedProduct["ReorderLevel"].ToString();
            chkDiscontinued.Checked = Convert.ToBoolean(selectedProduct["Discontinued"]);

            firstProductId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstProductId"]);
            previousProductId = ds.Tables[1].Rows[0]["PreviousProductId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousProductId"]) : (int?)null;
            nextProductId = ds.Tables[1].Rows[0]["NextProductId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextProductId"]) : (int?)null;
            lastProductId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastProductId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

            //Which item we are on in the count
            toolStripStatusLabel1.Text = $"Displaying product {currentRecord} of ?";
            NextPreviousButtonManagement();
        }

        #endregion

        #region [Navigation Helpers]

        /// <summary>
        /// Helps manage the enable state of our next and previous navigation buttons
        /// Depending on where we are in products we may need to set enable state based on position
        /// navigation through product records
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousProductId != null;
            btnNext.Enabled = nextProductId != null;
        }

        /// <summary>
        /// Helper method to set state of all nav buttons
        /// </summary>
        /// <param name="enableState"></param>
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        /// <summary>
        /// Handle navigation button interaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            toolStripStatusLabel2.Text = string.Empty;

            switch (b.Name)
            {
                case "btnFirst":
                    currentProductId = firstProductId;
                    toolStripStatusLabel2.Text = "The first product is currently displayed";
                    break;
                case "btnLast":
                    currentProductId = lastProductId;
                    toolStripStatusLabel2.Text = "The last product is currently displayed";
                    break;
                case "btnPrevious":
                    currentProductId = previousProductId.Value;

                    if (currentRecord == 1)
                        toolStripStatusLabel2.Text = "The first product is currently displayed";
                    break;
                case "btnNext":
                    currentProductId = nextProductId.Value;
                    
                    break;
            }

            LoadProductDetails();
        }

        #endregion

        #region [Validation Events and Methods]

        /// <summary>
        
       
        /// <summary>
        /// Numeric validation 
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <returns>The result of the validation</returns>
        private bool IsNumeric(string value)
        {
            return Double.TryParse(value, out double a);
        }

        #endregion

        #region [Form Helpers]
                
        /// <summary>
        /// Clear the form inputs and set checkbox unchecked
        /// </summary>
        /// <param name="controls">Controls collection to clear</param>
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }

        /// <summary>
        /// Animate the progress bar
        /// This is ui thread blocking. Ok for this application.
        /// </summary>
        private void ProgressBar()
        {
            this.toolStripStatusLabel3.Text = "Processing...";
            prgBar.Value = 0;
            this.statusStrip1.Refresh();

            while (prgBar.Value < prgBar.Maximum)
            {
                Thread.Sleep(15);
                prgBar.Value += 1;
            }

            prgBar.Value = 100;

            this.toolStripStatusLabel3.Text = "Processed";
        }

        /// <summary>
        /// Allow an invalid form to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #endregion
    }
}
