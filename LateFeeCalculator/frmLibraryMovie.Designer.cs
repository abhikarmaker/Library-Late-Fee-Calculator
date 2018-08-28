namespace LateFeeCalculator
{
    partial class frmLibraryMovie
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblNoOfDaysLate = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnTax = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtNumberofMovies = new System.Windows.Forms.TextBox();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtNoOfDaysLate = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(26, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 20);
            label2.TabIndex = 22;
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
            label3.TabIndex = 27;
            label3.Text = "Total :";
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
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFee.ForeColor = System.Drawing.Color.Black;
            this.lblLateFee.Location = new System.Drawing.Point(26, 239);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(74, 20);
            this.lblLateFee.TabIndex = 16;
            this.lblLateFee.Text = "Late Fee :";
            // 
            // lblNoOfDaysLate
            // 
            this.lblNoOfDaysLate.AutoSize = true;
            this.lblNoOfDaysLate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfDaysLate.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfDaysLate.Location = new System.Drawing.Point(26, 197);
            this.lblNoOfDaysLate.Name = "lblNoOfDaysLate";
            this.lblNoOfDaysLate.Size = new System.Drawing.Size(131, 20);
            this.lblNoOfDaysLate.TabIndex = 14;
            this.lblNoOfDaysLate.Text = "No Of Days Late : ";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentDate.Location = new System.Drawing.Point(26, 156);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(101, 20);
            this.lblCurrentDate.TabIndex = 12;
            this.lblCurrentDate.Text = "Current Date :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(26, 72);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(83, 20);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Library Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(174, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 20);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(174, 285);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(181, 20);
            this.txtTax.TabIndex = 26;
            this.txtTax.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(24, 283);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(81, 20);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "Tax(13%) :";
            // 
            // txtNumberofMovies
            // 
            this.txtNumberofMovies.Location = new System.Drawing.Point(174, 116);
            this.txtNumberofMovies.Name = "txtNumberofMovies";
            this.txtNumberofMovies.Size = new System.Drawing.Size(181, 20);
            this.txtNumberofMovies.TabIndex = 2;
            this.txtNumberofMovies.TextChanged += new System.EventHandler(this.ClearLateFee);
            // 
            // txtLateFee
            // 
            this.txtLateFee.Location = new System.Drawing.Point(174, 239);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(181, 20);
            this.txtLateFee.TabIndex = 31;
            this.txtLateFee.TabStop = false;
            // 
            // txtNoOfDaysLate
            // 
            this.txtNoOfDaysLate.Location = new System.Drawing.Point(174, 197);
            this.txtNoOfDaysLate.Name = "txtNoOfDaysLate";
            this.txtNoOfDaysLate.ReadOnly = true;
            this.txtNoOfDaysLate.Size = new System.Drawing.Size(181, 20);
            this.txtNoOfDaysLate.TabIndex = 30;
            this.txtNoOfDaysLate.TabStop = false;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(174, 156);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(181, 20);
            this.txtCurrentDate.TabIndex = 29;
            this.txtCurrentDate.TabStop = false;
            // 
            // frmLibraryMovie
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(383, 402);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtNoOfDaysLate);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.txtNumberofMovies);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.lblNoOfDaysLate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblDueDate);
            this.Name = "frmLibraryMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLibraryMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblNoOfDaysLate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtNumberofMovies;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.TextBox txtNoOfDaysLate;
        private System.Windows.Forms.TextBox txtCurrentDate;
    }
}