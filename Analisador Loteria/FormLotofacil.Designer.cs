namespace Analisador_Loteria
{
    partial class FormLotofacil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLotofacil));
            this.txtFechamentos = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.btnCarregarLocalPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFechamentos
            // 
            this.txtFechamentos.Location = new System.Drawing.Point(17, 9);
            this.txtFechamentos.Multiline = true;
            this.txtFechamentos.Name = "txtFechamentos";
            this.txtFechamentos.ReadOnly = true;
            this.txtFechamentos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFechamentos.Size = new System.Drawing.Size(298, 345);
            this.txtFechamentos.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 360);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(303, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Carregar Resultados";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(12, 445);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(303, 38);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(12, 390);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.ReadOnly = true;
            this.txtSaveFilePath.Size = new System.Drawing.Size(303, 20);
            this.txtSaveFilePath.TabIndex = 3;
            // 
            // btnCarregarLocalPath
            // 
            this.btnCarregarLocalPath.Location = new System.Drawing.Point(12, 416);
            this.btnCarregarLocalPath.Name = "btnCarregarLocalPath";
            this.btnCarregarLocalPath.Size = new System.Drawing.Size(303, 23);
            this.btnCarregarLocalPath.TabIndex = 4;
            this.btnCarregarLocalPath.Text = "Carregar Local Path";
            this.btnCarregarLocalPath.UseVisualStyleBackColor = true;
            this.btnCarregarLocalPath.Click += new System.EventHandler(this.btnCarregarLocalPath_Click);
            // 
            // FormLotofacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 495);
            this.Controls.Add(this.btnCarregarLocalPath);
            this.Controls.Add(this.txtSaveFilePath);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFechamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLotofacil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotofacil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechamentos;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.Button btnCarregarLocalPath;
    }
}