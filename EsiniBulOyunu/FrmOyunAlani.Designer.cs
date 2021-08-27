
namespace EsiniBulOyunu
{
    partial class FrmOyunAlani
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
            this.pnlKartlar = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDeneme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlKartlar
            // 
            this.pnlKartlar.Location = new System.Drawing.Point(12, 34);
            this.pnlKartlar.Name = "pnlKartlar";
            this.pnlKartlar.Size = new System.Drawing.Size(501, 476);
            this.pnlKartlar.TabIndex = 0;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(96, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(58, 13);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "Süre: 0 sn.";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Location = new System.Drawing.Point(12, 9);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(59, 13);
            this.lblDeneme.TabIndex = 1;
            this.lblDeneme.Text = "Deneme: 0";
            // 
            // FrmOyunAlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 530);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.pnlKartlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOyunAlani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul Oyunu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOyunAlani_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKartlar;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDeneme;
    }
}

