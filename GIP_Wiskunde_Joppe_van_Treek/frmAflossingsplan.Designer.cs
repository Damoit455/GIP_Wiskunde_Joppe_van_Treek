﻿namespace GIP_Wiskunde_Joppe_van_Treek
{
    partial class frmAflossingsplan
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAnnuiteit = new System.Windows.Forms.ComboBox();
            this.txtLooptijd = new System.Windows.Forms.TextBox();
            this.txtRente = new System.Windows.Forms.TextBox();
            this.txtGeleend = new System.Windows.Forms.TextBox();
            this.cbKeuzeAflossing = new System.Windows.Forms.ComboBox();
            this.pnlValues = new System.Windows.Forms.Panel();
            this.btnBereken = new System.Windows.Forms.Button();
            this.pnlAnnuiteit = new System.Windows.Forms.Panel();
            this.pnlValues.SuspendLayout();
            this.pnlAnnuiteit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 197);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Terug naar home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geleend bedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rente (per jaar)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Looptijd in maanden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Annuïteit berekenen per";
            // 
            // cbAnnuiteit
            // 
            this.cbAnnuiteit.FormattingEnabled = true;
            this.cbAnnuiteit.Location = new System.Drawing.Point(131, 0);
            this.cbAnnuiteit.Name = "cbAnnuiteit";
            this.cbAnnuiteit.Size = new System.Drawing.Size(121, 21);
            this.cbAnnuiteit.TabIndex = 6;
            // 
            // txtLooptijd
            // 
            this.txtLooptijd.Location = new System.Drawing.Point(131, 58);
            this.txtLooptijd.Name = "txtLooptijd";
            this.txtLooptijd.Size = new System.Drawing.Size(121, 20);
            this.txtLooptijd.TabIndex = 7;
            // 
            // txtRente
            // 
            this.txtRente.Location = new System.Drawing.Point(131, 32);
            this.txtRente.Name = "txtRente";
            this.txtRente.Size = new System.Drawing.Size(121, 20);
            this.txtRente.TabIndex = 8;
            // 
            // txtGeleend
            // 
            this.txtGeleend.Location = new System.Drawing.Point(131, 6);
            this.txtGeleend.Name = "txtGeleend";
            this.txtGeleend.Size = new System.Drawing.Size(121, 20);
            this.txtGeleend.TabIndex = 9;
            // 
            // cbKeuzeAflossing
            // 
            this.cbKeuzeAflossing.FormattingEnabled = true;
            this.cbKeuzeAflossing.Location = new System.Drawing.Point(12, 12);
            this.cbKeuzeAflossing.Name = "cbKeuzeAflossing";
            this.cbKeuzeAflossing.Size = new System.Drawing.Size(250, 21);
            this.cbKeuzeAflossing.TabIndex = 10;
            this.cbKeuzeAflossing.SelectedIndexChanged += new System.EventHandler(this.cbKeuzeAflossing_SelectedIndexChanged);
            // 
            // pnlValues
            // 
            this.pnlValues.Controls.Add(this.btnBereken);
            this.pnlValues.Controls.Add(this.label1);
            this.pnlValues.Controls.Add(this.label2);
            this.pnlValues.Controls.Add(this.txtGeleend);
            this.pnlValues.Controls.Add(this.label3);
            this.pnlValues.Controls.Add(this.txtRente);
            this.pnlValues.Controls.Add(this.txtLooptijd);
            this.pnlValues.Location = new System.Drawing.Point(12, 39);
            this.pnlValues.Name = "pnlValues";
            this.pnlValues.Size = new System.Drawing.Size(439, 152);
            this.pnlValues.TabIndex = 11;
            this.pnlValues.Visible = false;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(0, 121);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(94, 28);
            this.btnBereken.TabIndex = 10;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // pnlAnnuiteit
            // 
            this.pnlAnnuiteit.Controls.Add(this.cbAnnuiteit);
            this.pnlAnnuiteit.Controls.Add(this.label4);
            this.pnlAnnuiteit.Location = new System.Drawing.Point(12, 123);
            this.pnlAnnuiteit.Name = "pnlAnnuiteit";
            this.pnlAnnuiteit.Size = new System.Drawing.Size(269, 31);
            this.pnlAnnuiteit.TabIndex = 10;
            // 
            // frmAflossingsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 243);
            this.Controls.Add(this.pnlAnnuiteit);
            this.Controls.Add(this.pnlValues);
            this.Controls.Add(this.cbKeuzeAflossing);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAflossingsplan";
            this.Text = "Aflossingsplan";
            this.Load += new System.EventHandler(this.frmAflossingsplan_Load);
            this.pnlValues.ResumeLayout(false);
            this.pnlValues.PerformLayout();
            this.pnlAnnuiteit.ResumeLayout(false);
            this.pnlAnnuiteit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAnnuiteit;
        private System.Windows.Forms.TextBox txtLooptijd;
        private System.Windows.Forms.TextBox txtRente;
        private System.Windows.Forms.TextBox txtGeleend;
        private System.Windows.Forms.ComboBox cbKeuzeAflossing;
        private System.Windows.Forms.Panel pnlValues;
        private System.Windows.Forms.Panel pnlAnnuiteit;
        private System.Windows.Forms.Button btnBereken;
    }
}