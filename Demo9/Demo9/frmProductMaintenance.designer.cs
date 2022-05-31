﻿namespace DBProgrammingDemo9
{
    partial class frmProductMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOnOrder = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.prgBar,
            this.toolStripStatusLabel3});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // prgBar
            // 
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.txtProductId);
            this.grpProducts.Controls.Add(this.label1);
            this.grpProducts.Controls.Add(this.btnCancel);
            this.grpProducts.Controls.Add(this.btnLast);
            this.grpProducts.Controls.Add(this.chkDiscontinued);
            this.grpProducts.Controls.Add(this.label8);
            this.grpProducts.Controls.Add(this.txtReorder);
            this.grpProducts.Controls.Add(this.label7);
            this.grpProducts.Controls.Add(this.txtOnOrder);
            this.grpProducts.Controls.Add(this.btnAdd);
            this.grpProducts.Controls.Add(this.label6);
            this.grpProducts.Controls.Add(this.txtStock);
            this.grpProducts.Controls.Add(this.label5);
            this.grpProducts.Controls.Add(this.txtUnitPrice);
            this.grpProducts.Controls.Add(this.label4);
            this.grpProducts.Controls.Add(this.btnDelete);
            this.grpProducts.Controls.Add(this.btnFirst);
            this.grpProducts.Controls.Add(this.btnSave);
            this.grpProducts.Controls.Add(this.btnPrevious);
            this.grpProducts.Controls.Add(this.btnNext);
            this.grpProducts.Controls.Add(this.cmbCategories);
            this.grpProducts.Controls.Add(this.label10);
            this.grpProducts.Controls.Add(this.cmbSuppliers);
            this.grpProducts.Controls.Add(this.label9);
            this.grpProducts.Controls.Add(this.txtQtyPerUnit);
            this.grpProducts.Controls.Add(this.label3);
            this.grpProducts.Controls.Add(this.txtProductName);
            this.grpProducts.Controls.Add(this.label2);
            this.grpProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProducts.Location = new System.Drawing.Point(34, 22);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(430, 555);
            this.grpProducts.TabIndex = 6;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Product Details";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(49, 41);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(336, 20);
            this.txtProductId.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 47);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(310, 453);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(81, 43);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(49, 430);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chkDiscontinued.TabIndex = 13;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Discontinued?";
            // 
            // txtReorder
            // 
            this.txtReorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorder.Location = new System.Drawing.Point(49, 387);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(336, 20);
            this.txtReorder.TabIndex = 11;
            this.txtReorder.Tag = "Reorder Level";
            this.txtReorder.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Re-order Level:";
            // 
            // txtOnOrder
            // 
            this.txtOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnOrder.Location = new System.Drawing.Point(49, 344);
            this.txtOnOrder.Name = "txtOnOrder";
            this.txtOnOrder.Size = new System.Drawing.Size(336, 20);
            this.txtOnOrder.TabIndex = 9;
            this.txtOnOrder.Tag = "On Order";
            this.txtOnOrder.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(49, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 47);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Units on order:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(49, 301);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(336, 20);
            this.txtStock.TabIndex = 7;
            this.txtStock.Tag = "Stock";
            this.txtStock.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Units in stock:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(49, 258);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(336, 20);
            this.txtUnitPrice.TabIndex = 5;
            this.txtUnitPrice.Tag = "Unit Price";
            this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit Price:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(136, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 47);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(49, 453);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(81, 43);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 47);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(136, 453);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 43);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(223, 453);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 43);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(49, 171);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(336, 21);
            this.cmbCategories.TabIndex = 17;
            this.cmbCategories.Tag = "Category";
            this.cmbCategories.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Category:";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(49, 127);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(336, 21);
            this.cmbSuppliers.TabIndex = 15;
            this.cmbSuppliers.Tag = "Supplier";
            this.cmbSuppliers.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Supplier:";
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyPerUnit.Location = new System.Drawing.Point(49, 215);
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(336, 20);
            this.txtQtyPerUnit.TabIndex = 3;
            this.txtQtyPerUnit.Tag = "Qty per Unit";
            this.txtQtyPerUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty per unit:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(49, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(336, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Tag = "Product Name";
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // frmProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(506, 621);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmProductMaintenance";
            this.Text = "Product Maintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductMaintenance_FormClosing);
            this.Load += new System.EventHandler(this.frmProductMaintenance_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOnOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripProgressBar prgBar;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

