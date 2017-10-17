namespace GIP_Wiskunde_Joppe_van_Treek
{
    partial class Startpage
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
            this.btnAflossing = new System.Windows.Forms.Button();
            this.btnIntrest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAflossing
            // 
            this.btnAflossing.Location = new System.Drawing.Point(12, 12);
            this.btnAflossing.Name = "btnAflossing";
            this.btnAflossing.Size = new System.Drawing.Size(260, 63);
            this.btnAflossing.TabIndex = 0;
            this.btnAflossing.Text = "Aflossingsplan";
            this.btnAflossing.UseVisualStyleBackColor = true;
            this.btnAflossing.Click += new System.EventHandler(this.btnAflossing_Click);
            // 
            // btnIntrest
            // 
            this.btnIntrest.Location = new System.Drawing.Point(12, 81);
            this.btnIntrest.Name = "btnIntrest";
            this.btnIntrest.Size = new System.Drawing.Size(260, 63);
            this.btnIntrest.TabIndex = 1;
            this.btnIntrest.Text = "Intrestberekening";
            this.btnIntrest.UseVisualStyleBackColor = true;
            this.btnIntrest.Click += new System.EventHandler(this.btnIntrest_Click);
            // 
            // Startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.btnIntrest);
            this.Controls.Add(this.btnAflossing);
            this.Name = "Startpage";
            this.Text = "Home";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAflossing;
        private System.Windows.Forms.Button btnIntrest;
    }
}

