
namespace EsiniBulOyunu
{
    partial class FrmOyunMenu
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
            this.btn2x2 = new System.Windows.Forms.Button();
            this.btn4x4 = new System.Windows.Forms.Button();
            this.btn8x8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2x2
            // 
            this.btn2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2x2.Location = new System.Drawing.Point(159, 58);
            this.btn2x2.Name = "btn2x2";
            this.btn2x2.Size = new System.Drawing.Size(156, 46);
            this.btn2x2.TabIndex = 0;
            this.btn2x2.Text = "2 x 2";
            this.btn2x2.UseVisualStyleBackColor = true;
            this.btn2x2.Click += new System.EventHandler(this.btn2x2_Click);
            // 
            // btn4x4
            // 
            this.btn4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4x4.Location = new System.Drawing.Point(159, 185);
            this.btn4x4.Name = "btn4x4";
            this.btn4x4.Size = new System.Drawing.Size(156, 46);
            this.btn4x4.TabIndex = 1;
            this.btn4x4.Text = "4 x 4";
            this.btn4x4.UseVisualStyleBackColor = true;
            this.btn4x4.Click += new System.EventHandler(this.btn4x4_Click);
            // 
            // btn8x8
            // 
            this.btn8x8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8x8.Location = new System.Drawing.Point(159, 317);
            this.btn8x8.Name = "btn8x8";
            this.btn8x8.Size = new System.Drawing.Size(156, 46);
            this.btn8x8.TabIndex = 2;
            this.btn8x8.Text = "8 x 8";
            this.btn8x8.UseVisualStyleBackColor = true;
            this.btn8x8.Click += new System.EventHandler(this.btn8x8_Click);
            // 
            // FrmOyunMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn8x8);
            this.Controls.Add(this.btn4x4);
            this.Controls.Add(this.btn2x2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOyunMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul Oyunu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOyunMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2x2;
        private System.Windows.Forms.Button btn4x4;
        private System.Windows.Forms.Button btn8x8;
    }
}