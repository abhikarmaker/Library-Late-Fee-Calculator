namespace LateFeeCalculator
{
    partial class frmNewRelease
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
            System.Windows.Forms.Label lblDueDate;
            System.Windows.Forms.Label lblCurrentDate;
            System.Windows.Forms.Label lblNoOfDaysLate;
            System.Windows.Forms.Label lblLateFee;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.txtNoOfDaysLate = new System.Windows.Forms.TextBox();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberofMovies = new System.Windows.Forms.TextBox();
            this.btnTax = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            lblDueDate = new System.Windows.Forms.Label();
            lblCurrentDate = new System.Windows.Forms.Label();
            lblNoOfDaysLate = new System.Windows.Forms.Label();
            lblLateFee = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDueDate.ForeColor = System.Drawing.Color.Black;
            lblDueDate.Location = new System.Drawing.Point(26, 72);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new System.Drawing.Size(83, 20);
            lblDueDate.TabIndex = 0;
            lblDueDate.Text = "Due Date : ";
            lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCurrentDate.ForeColor = System.Drawing.Color.Black;
            lblCurrentDate.Location = new System.Drawing.Point(26, 156);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new System.Drawing.Size(101, 20);
            lblCurrentDate.TabIndex = 2;
            lblCurrentDate.Text = "Current Date :";
            // 
            // lblNoOfDaysLate
            // 
            lblNoOfDaysLate.AutoSize = true;
            lblNoOfDaysLate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNoOfDaysLate.ForeColor = System.Drawing.Color.Black;
            lblNoOfDaysLate.Location = new System.Drawing.Point(26, 197);
            lblNoOfDaysLate.Name = "lblNoOfDaysLate";
            lblNoOfDaysLate.Size = new System.Drawing.Size(131, 20);
            lblNoOfDaysLate.TabIndex = 4;
            lblNoOfDaysLate.Text = "No Of Days Late : ";
            // 
            // lblLateFee
            // 
            lblLateFee.AutoSize = true;
            lblLateFee.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLateFee.ForeColor = System.Drawing.Color.Black;
            lblLateFee.Location = new System.Drawing.Point(26, 239);
            lblLateFee.Name = "lblLateFee";
            lblLateFee.Size = new System.Drawing.Size(74, 20);
            lblLateFee.TabIndex = 6;
            lblLateFee.Text = "Late Fee :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(26, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 20);
            label2.TabIndex = 11;
            label2.Text = "Number of Movies : ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(26, 327);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 15;
            label3.Text = "Total :";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(174, 156);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(181, 20);
            this.txtCurrentDate.TabIndex = 5;
            this.txtCurrentDate.TabStop = false;
            // 
            // txtNoOfDaysLate
            // 
            this.txtNoOfDaysLate.Location = new System.Drawing.Point(174, 197);
            this.txtNoOfDaysLate.Name = "txtNoOfDaysLate";
            this.txtNoOfDaysLate.ReadOnly = true;
            this.txtNoOfDaysLate.Size = new System.Drawing.Size(181, 20);
            this.txtNoOfDaysLate.TabIndex = 6;
            this.txtNoOfDaysLate.TabStop = false;
            // 
            // txtLateFee
            // 
            this.txtLateFee.Location = new System.Drawing.Point(174, 239);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(181, 20);
            this.txtLateFee.TabIndex = 7;
            this.txtLateFee.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(4, 361);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 33);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(292, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Release";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumberofMovies
            // 
            this.txtNumberofMovies.Location = new System.Drawing.Point(174, 116);
            this.txtNumberofMovies.Name = "txtNumberofMovies";
            this.txtNumberofMovies.Size = new System.Drawing.Size(181, 20);
            this.txtNumberofMovies.TabIndex = 2;
            this.txtNumberofMovies.TextChanged += new System.EventHandler(this.ClearLateFee);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(154, 361);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(86, 33);
            this.btnTax.TabIndex = 4;
            this.btnTax.Text = "&Tax Percent";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.TextChanged += new System.EventHandler(this.ClearLateFee);
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(24, 283);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(81, 20);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax(13%) :";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(174, 285);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(181, 20);
            this.txtTax.TabIndex = 14;
            this.txtTax.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(174, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TabStop = false;
            // 
            // dtDueDate
            // 
            this.dtDueDate.CustomFormat = "MM-dd-yyyy";
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(174, 72);
            this.dtDueDate.MaxDate = new System.DateTime(2049, 12, 31, 0, 0, 0, 0);
            this.dtDueDate.MinDate = new System.DateTime(1991, 12, 10, 0, 0, 0, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(181, 20);
            this.dtDueDate.TabIndex = 1;
            // 
            // frmNewRelease
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(383, 402);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.txtNumberofMovies);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtNoOfDaysLate);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(lblLateFee);
            this.Controls.Add(lblNoOfDaysLate);
            this.Controls.Add(lblCurrentDate);
            this.Controls.Add(lblDueDate);
            this.Name = "frmNewRelease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewRelease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.TextBox txtNoOfDaysLate;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberofMovies;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtDueDate;
    }
}