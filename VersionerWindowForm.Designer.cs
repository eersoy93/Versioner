namespace Versioner
{
    partial class VersionerWindowForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.VersionerLabel1 = new System.Windows.Forms.Label();
            this.VersionerLabel2 = new System.Windows.Forms.Label();
            this.VersionerLabel3 = new System.Windows.Forms.Label();
            this.VersionerText1 = new System.Windows.Forms.TextBox();
            this.VersionerText2 = new System.Windows.Forms.TextBox();
            this.VersionerText3 = new System.Windows.Forms.TextBox();
            this.VersionerLabelLicense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VersionerLabel1
            // 
            this.VersionerLabel1.AutoSize = true;
            this.VersionerLabel1.ForeColor = System.Drawing.Color.Lime;
            this.VersionerLabel1.Location = new System.Drawing.Point(12, 9);
            this.VersionerLabel1.Name = "VersionerLabel1";
            this.VersionerLabel1.Size = new System.Drawing.Size(157, 16);
            this.VersionerLabel1.TabIndex = 0;
            this.VersionerLabel1.Text = "Operating System Name:";
            // 
            // VersionerLabel2
            // 
            this.VersionerLabel2.AutoSize = true;
            this.VersionerLabel2.ForeColor = System.Drawing.Color.Lime;
            this.VersionerLabel2.Location = new System.Drawing.Point(12, 46);
            this.VersionerLabel2.Name = "VersionerLabel2";
            this.VersionerLabel2.Size = new System.Drawing.Size(166, 16);
            this.VersionerLabel2.TabIndex = 1;
            this.VersionerLabel2.Text = "Operating System Version:";
            // 
            // VersionerLabel3
            // 
            this.VersionerLabel3.AutoSize = true;
            this.VersionerLabel3.ForeColor = System.Drawing.Color.Lime;
            this.VersionerLabel3.Location = new System.Drawing.Point(12, 86);
            this.VersionerLabel3.Name = "VersionerLabel3";
            this.VersionerLabel3.Size = new System.Drawing.Size(199, 16);
            this.VersionerLabel3.TabIndex = 2;
            this.VersionerLabel3.Text = "Windows Service Pack Number:";
            // 
            // VersionerText1
            // 
            this.VersionerText1.BackColor = System.Drawing.Color.DarkGray;
            this.VersionerText1.Location = new System.Drawing.Point(234, 6);
            this.VersionerText1.Name = "VersionerText1";
            this.VersionerText1.ReadOnly = true;
            this.VersionerText1.Size = new System.Drawing.Size(389, 22);
            this.VersionerText1.TabIndex = 3;
            // 
            // VersionerText2
            // 
            this.VersionerText2.BackColor = System.Drawing.Color.DarkGray;
            this.VersionerText2.Location = new System.Drawing.Point(234, 43);
            this.VersionerText2.Name = "VersionerText2";
            this.VersionerText2.ReadOnly = true;
            this.VersionerText2.Size = new System.Drawing.Size(389, 22);
            this.VersionerText2.TabIndex = 4;
            // 
            // VersionerText3
            // 
            this.VersionerText3.BackColor = System.Drawing.Color.DarkGray;
            this.VersionerText3.Location = new System.Drawing.Point(234, 83);
            this.VersionerText3.Name = "VersionerText3";
            this.VersionerText3.ReadOnly = true;
            this.VersionerText3.Size = new System.Drawing.Size(389, 22);
            this.VersionerText3.TabIndex = 5;
            // 
            // VersionerLabelLicense
            // 
            this.VersionerLabelLicense.AutoSize = true;
            this.VersionerLabelLicense.ForeColor = System.Drawing.Color.Lime;
            this.VersionerLabelLicense.Location = new System.Drawing.Point(12, 121);
            this.VersionerLabelLicense.Name = "VersionerLabelLicense";
            this.VersionerLabelLicense.Size = new System.Drawing.Size(614, 16);
            this.VersionerLabelLicense.TabIndex = 6;
            this.VersionerLabelLicense.Text = "Copyright (c) 2022 Erdem Ersoy. Licensed with GPLv3. See LICENSE file in source c" +
    "ode for license text.";
            // 
            // VersionerWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(635, 156);
            this.Controls.Add(this.VersionerLabelLicense);
            this.Controls.Add(this.VersionerText3);
            this.Controls.Add(this.VersionerText2);
            this.Controls.Add(this.VersionerText1);
            this.Controls.Add(this.VersionerLabel3);
            this.Controls.Add(this.VersionerLabel2);
            this.Controls.Add(this.VersionerLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VersionerWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versioner - Created By Erdem Ersoy";
            this.Load += new System.EventHandler(this.VersionerWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionerLabel1;
        private System.Windows.Forms.Label VersionerLabel2;
        private System.Windows.Forms.Label VersionerLabel3;
        private System.Windows.Forms.TextBox VersionerText1;
        private System.Windows.Forms.TextBox VersionerText2;
        private System.Windows.Forms.TextBox VersionerText3;
        private System.Windows.Forms.Label VersionerLabelLicense;
    }
}

