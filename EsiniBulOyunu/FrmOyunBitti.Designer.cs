
namespace EsiniBulOyunu
{
    partial class FrmOyunBitti
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
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.lblSureBaslik = new System.Windows.Forms.Label();
            this.lblDenemeBaslik = new System.Windows.Forms.Label();
            this.btnTekrarOyna = new System.Windows.Forms.Button();
            this.lblDeneme = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnOyunuKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.AutoSize = true;
            this.lblOyunBitti.Font = new System.Drawing.Font("Cooper Std Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunBitti.Location = new System.Drawing.Point(39, 30);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(417, 77);
            this.lblOyunBitti.TabIndex = 0;
            this.lblOyunBitti.Text = "Oyun Bitti!";
            // 
            // lblSureBaslik
            // 
            this.lblSureBaslik.AutoSize = true;
            this.lblSureBaslik.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSureBaslik.Location = new System.Drawing.Point(45, 206);
            this.lblSureBaslik.Name = "lblSureBaslik";
            this.lblSureBaslik.Size = new System.Drawing.Size(195, 40);
            this.lblSureBaslik.TabIndex = 1;
            this.lblSureBaslik.Text = "Süre (sn):";
            // 
            // lblDenemeBaslik
            // 
            this.lblDenemeBaslik.AutoSize = true;
            this.lblDenemeBaslik.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenemeBaslik.Location = new System.Drawing.Point(45, 139);
            this.lblDenemeBaslik.Name = "lblDenemeBaslik";
            this.lblDenemeBaslik.Size = new System.Drawing.Size(284, 40);
            this.lblDenemeBaslik.TabIndex = 2;
            this.lblDenemeBaslik.Text = "Deneme Sayısı:";
            // 
            // btnTekrarOyna
            // 
            this.btnTekrarOyna.Location = new System.Drawing.Point(52, 285);
            this.btnTekrarOyna.Name = "btnTekrarOyna";
            this.btnTekrarOyna.Size = new System.Drawing.Size(383, 57);
            this.btnTekrarOyna.TabIndex = 3;
            this.btnTekrarOyna.Text = "Tekrar Oyna";
            this.btnTekrarOyna.UseVisualStyleBackColor = true;
            this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeneme.Location = new System.Drawing.Point(397, 139);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(38, 40);
            this.lblDeneme.TabIndex = 4;
            this.lblDeneme.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(397, 206);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(38, 40);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "0";
            // 
            // btnOyunuKapat
            // 
            this.btnOyunuKapat.Location = new System.Drawing.Point(52, 372);
            this.btnOyunuKapat.Name = "btnOyunuKapat";
            this.btnOyunuKapat.Size = new System.Drawing.Size(383, 57);
            this.btnOyunuKapat.TabIndex = 6;
            this.btnOyunuKapat.Text = "Oyunu Kapat";
            this.btnOyunuKapat.UseVisualStyleBackColor = true;
            this.btnOyunuKapat.Click += new System.EventHandler(this.btnOyunuKapat_Click);
            // 
            // FrmOyunBitti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnOyunuKapat);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.btnTekrarOyna);
            this.Controls.Add(this.lblDenemeBaslik);
            this.Controls.Add(this.lblSureBaslik);
            this.Controls.Add(this.lblOyunBitti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOyunBitti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyunBitti;
        private System.Windows.Forms.Label lblSureBaslik;
        private System.Windows.Forms.Label lblDenemeBaslik;
        private System.Windows.Forms.Button btnTekrarOyna;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnOyunuKapat;
    }
}