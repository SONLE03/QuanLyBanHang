namespace Supermarket
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.Customer = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.dataGridView_addOrder = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTotal = new System.Windows.Forms.Label();
            this.BprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.BprintDocument = new System.Drawing.Printing.PrintDocument();
            this.Employee = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(118, 162);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(392, 31);
            this.Customer.TabIndex = 3;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(673, 86);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(392, 31);
            this.Product.TabIndex = 4;
            this.Product.SelectedValueChanged += new System.EventHandler(this.Product_SelectedValueChanged);
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(673, 239);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(392, 30);
            this.Quantity.TabIndex = 6;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên - Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(679, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(673, 312);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(110, 40);
            this.AddOrder.TabIndex = 14;
            this.AddOrder.Text = "Thêm";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(805, 312);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 40);
            this.delete.TabIndex = 15;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(935, 312);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(130, 40);
            this.print.TabIndex = 16;
            this.print.Text = "Thanh toán";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // dataGridView_addOrder
            // 
            this.dataGridView_addOrder.AllowUserToAddRows = false;
            this.dataGridView_addOrder.AllowUserToDeleteRows = false;
            this.dataGridView_addOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_addOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.Tensp,
            this.Dongia,
            this.Soluong,
            this.Thanhtien});
            this.dataGridView_addOrder.Location = new System.Drawing.Point(55, 368);
            this.dataGridView_addOrder.Name = "dataGridView_addOrder";
            this.dataGridView_addOrder.ReadOnly = true;
            this.dataGridView_addOrder.RowHeadersWidth = 51;
            this.dataGridView_addOrder.RowTemplate.Height = 24;
            this.dataGridView_addOrder.Size = new System.Drawing.Size(1093, 337);
            this.dataGridView_addOrder.TabIndex = 18;
            // 
            // Masp
            // 
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.MinimumWidth = 6;
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Width = 125;
            // 
            // Tensp
            // 
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.MinimumWidth = 6;
            this.Tensp.Name = "Tensp";
            this.Tensp.ReadOnly = true;
            this.Tensp.Width = 125;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            this.Dongia.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 125;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 125;
            // 
            // gTotal
            // 
            this.gTotal.AutoSize = true;
            this.gTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotal.Location = new System.Drawing.Point(936, 726);
            this.gTotal.Name = "gTotal";
            this.gTotal.Size = new System.Drawing.Size(0, 28);
            this.gTotal.TabIndex = 19;
            // 
            // BprintPreviewDialog
            // 
            this.BprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BprintPreviewDialog.Enabled = true;
            this.BprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BprintPreviewDialog.Icon")));
            this.BprintPreviewDialog.Name = "BprintPreviewDialog";
            this.BprintPreviewDialog.Visible = false;
            // 
            // BprintDocument
            // 
            this.BprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BprintDocument_PrintPage);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(3, 1);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(0, 25);
            this.Employee.TabIndex = 20;
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(3, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(0, 25);
            this.datetime.TabIndex = 21;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(3, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 25);
            this.id.TabIndex = 22;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(3, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 25);
            this.price.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Employee);
            this.panel1.Location = new System.Drawing.Point(118, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 31);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datetime);
            this.panel2.Location = new System.Drawing.Point(118, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 31);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.price);
            this.panel3.Location = new System.Drawing.Point(673, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 31);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.id);
            this.panel4.Location = new System.Drawing.Point(118, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 31);
            this.panel4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(800, 726);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "Thành tiền:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(118, 724);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 40);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gTotal);
            this.Controls.Add(this.dataGridView_addOrder);
            this.Controls.Add(this.print);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridView dataGridView_addOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Label gTotal;
        private System.Windows.Forms.PrintPreviewDialog BprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument BprintDocument;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Exit;
    }
}