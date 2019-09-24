namespace Analisador_Loteria
{
    partial class FormHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.btnLotofacil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLotofacil
            // 
            this.btnLotofacil.BackColor = System.Drawing.Color.Purple;
            this.btnLotofacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotofacil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLotofacil.Location = new System.Drawing.Point(323, 179);
            this.btnLotofacil.Name = "btnLotofacil";
            this.btnLotofacil.Size = new System.Drawing.Size(159, 81);
            this.btnLotofacil.TabIndex = 0;
            this.btnLotofacil.Text = "Lotofácil";
            this.btnLotofacil.UseVisualStyleBackColor = false;
            this.btnLotofacil.Click += new System.EventHandler(this.btnLotofacil_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLotofacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisador de Loteria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLotofacil;
    }
}

