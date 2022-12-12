namespace Supermarket
{
    partial class SetPass
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
            this.Exit = new System.Windows.Forms.Button();
            this.CN_Pass = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.N_Pass = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(259, 301);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 36);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CN_Pass
            // 
            this.CN_Pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CN_Pass.Location = new System.Drawing.Point(65, 219);
            this.CN_Pass.Multiline = true;
            this.CN_Pass.Name = "CN_Pass";
            this.CN_Pass.Size = new System.Drawing.Size(312, 36);
            this.CN_Pass.TabIndex = 14;
            this.CN_Pass.Text = "Xác nhận mật khẩu mới";
            this.CN_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(65, 301);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(169, 36);
            this.Save.TabIndex = 13;
            this.Save.Text = "Đặt lại mật khẩu";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // N_Pass
            // 
            this.N_Pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Pass.Location = new System.Drawing.Point(65, 164);
            this.N_Pass.Multiline = true;
            this.N_Pass.Name = "N_Pass";
            this.N_Pass.Size = new System.Drawing.Size(312, 36);
            this.N_Pass.TabIndex = 12;
            this.N_Pass.Text = "Mật khẩu mới";
            this.N_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(65, 108);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(312, 36);
            this.Code.TabIndex = 16;
            this.Code.Text = "Mã xác nhận";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(124, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cập nhật mật khẩu";
            // 
            // SetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CN_Pass);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.N_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetPass";
            this.Text = "SetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox CN_Pass;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox N_Pass;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label1;
    }
}