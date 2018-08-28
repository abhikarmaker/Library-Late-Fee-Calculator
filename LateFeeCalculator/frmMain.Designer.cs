namespace LateFeeCalculator
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnAddRemoveMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Late Fee Calculator";
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(9, 298);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(91, 33);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release ";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Location = new System.Drawing.Point(105, 298);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(89, 33);
            this.btnLibraryMovie.TabIndex = 2;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Location = new System.Drawing.Point(200, 298);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(84, 33);
            this.btnKidsMovie.TabIndex = 3;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            this.btnKidsMovie.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(379, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCurrent
            // 
            this.txtCurrent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.ForeColor = System.Drawing.Color.Black;
            this.txtCurrent.Location = new System.Drawing.Point(356, 12);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(101, 19);
            this.txtCurrent.TabIndex = 5;
            // 
            // btnAddRemoveMovies
            // 
            this.btnAddRemoveMovies.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddRemoveMovies.Location = new System.Drawing.Point(289, 298);
            this.btnAddRemoveMovies.Name = "btnAddRemoveMovies";
            this.btnAddRemoveMovies.Size = new System.Drawing.Size(86, 33);
            this.btnAddRemoveMovies.TabIndex = 6;
            this.btnAddRemoveMovies.TabStop = false;
            this.btnAddRemoveMovies.Text = "&Add or Rem";
            this.btnAddRemoveMovies.UseVisualStyleBackColor = true;
            this.btnAddRemoveMovies.Click += new System.EventHandler(this.btnAddRemoveMovies_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnNewRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(472, 343);
            this.Controls.Add(this.btnAddRemoveMovies);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Button btnKidsMovie;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnAddRemoveMovies;
    }
}

