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
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.cbColumn = new System.Windows.Forms.CheckBox();
            this.cbSum = new System.Windows.Forms.CheckBox();
            this.cbPosition = new System.Windows.Forms.CheckBox();
            this.cbPrimeNumber = new System.Windows.Forms.CheckBox();
            this.cbOddEven = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.cbInvertido = new System.Windows.Forms.CheckBox();
            this.cbDuplicado = new System.Windows.Forms.CheckBox();
            this.cbGroup2 = new System.Windows.Forms.CheckBox();
            this.cbGroup4 = new System.Windows.Forms.CheckBox();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.cbGroup3 = new System.Windows.Forms.CheckBox();
            this.cbGroup5 = new System.Windows.Forms.CheckBox();
            this.cbGroup6 = new System.Windows.Forms.CheckBox();
            this.cbGroup7 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFechamentos
            // 
            this.txtFechamentos.Location = new System.Drawing.Point(17, 9);
            this.txtFechamentos.MaxLength = 999999999;
            this.txtFechamentos.Multiline = true;
            this.txtFechamentos.Name = "txtFechamentos";
            this.txtFechamentos.ReadOnly = true;
            this.txtFechamentos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFechamentos.Size = new System.Drawing.Size(298, 368);
            this.txtFechamentos.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 382);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(383, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Carregar Resultados";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(12, 467);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(383, 38);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(12, 412);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.ReadOnly = true;
            this.txtSaveFilePath.Size = new System.Drawing.Size(384, 20);
            this.txtSaveFilePath.TabIndex = 3;
            // 
            // btnCarregarLocalPath
            // 
            this.btnCarregarLocalPath.Location = new System.Drawing.Point(12, 438);
            this.btnCarregarLocalPath.Name = "btnCarregarLocalPath";
            this.btnCarregarLocalPath.Size = new System.Drawing.Size(383, 23);
            this.btnCarregarLocalPath.TabIndex = 4;
            this.btnCarregarLocalPath.Text = "Carregar Local Path";
            this.btnCarregarLocalPath.UseVisualStyleBackColor = true;
            this.btnCarregarLocalPath.Click += new System.EventHandler(this.btnCarregarLocalPath_Click);
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.Location = new System.Drawing.Point(323, 31);
            this.cbLine.Margin = new System.Windows.Forms.Padding(2);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(57, 17);
            this.cbLine.TabIndex = 5;
            this.cbLine.Text = "Linhas";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // cbColumn
            // 
            this.cbColumn.AutoSize = true;
            this.cbColumn.Location = new System.Drawing.Point(323, 53);
            this.cbColumn.Margin = new System.Windows.Forms.Padding(2);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(64, 17);
            this.cbColumn.TabIndex = 6;
            this.cbColumn.Text = "Colunas";
            this.cbColumn.UseVisualStyleBackColor = true;
            // 
            // cbSum
            // 
            this.cbSum.AutoSize = true;
            this.cbSum.Location = new System.Drawing.Point(323, 75);
            this.cbSum.Margin = new System.Windows.Forms.Padding(2);
            this.cbSum.Name = "cbSum";
            this.cbSum.Size = new System.Drawing.Size(53, 17);
            this.cbSum.TabIndex = 7;
            this.cbSum.Text = "Soma";
            this.cbSum.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.AutoSize = true;
            this.cbPosition.Location = new System.Drawing.Point(323, 97);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(64, 17);
            this.cbPosition.TabIndex = 8;
            this.cbPosition.Text = "Posição";
            this.cbPosition.UseVisualStyleBackColor = true;
            // 
            // cbPrimeNumber
            // 
            this.cbPrimeNumber.AutoSize = true;
            this.cbPrimeNumber.Location = new System.Drawing.Point(323, 119);
            this.cbPrimeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrimeNumber.Name = "cbPrimeNumber";
            this.cbPrimeNumber.Size = new System.Drawing.Size(57, 17);
            this.cbPrimeNumber.TabIndex = 9;
            this.cbPrimeNumber.Text = "Primos";
            this.cbPrimeNumber.UseVisualStyleBackColor = true;
            // 
            // cbOddEven
            // 
            this.cbOddEven.AutoSize = true;
            this.cbOddEven.Location = new System.Drawing.Point(323, 141);
            this.cbOddEven.Margin = new System.Windows.Forms.Padding(2);
            this.cbOddEven.Name = "cbOddEven";
            this.cbOddEven.Size = new System.Drawing.Size(73, 17);
            this.cbOddEven.TabIndex = 12;
            this.cbOddEven.Text = "Impar/Par";
            this.cbOddEven.UseVisualStyleBackColor = true;
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Location = new System.Drawing.Point(322, 162);
            this.cbNormal.Margin = new System.Windows.Forms.Padding(2);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(59, 17);
            this.cbNormal.TabIndex = 16;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // cbInvertido
            // 
            this.cbInvertido.AutoSize = true;
            this.cbInvertido.Location = new System.Drawing.Point(322, 184);
            this.cbInvertido.Margin = new System.Windows.Forms.Padding(2);
            this.cbInvertido.Name = "cbInvertido";
            this.cbInvertido.Size = new System.Drawing.Size(67, 17);
            this.cbInvertido.TabIndex = 17;
            this.cbInvertido.Text = "Invertido";
            this.cbInvertido.UseVisualStyleBackColor = true;
            // 
            // cbDuplicado
            // 
            this.cbDuplicado.AutoSize = true;
            this.cbDuplicado.Location = new System.Drawing.Point(323, 206);
            this.cbDuplicado.Margin = new System.Windows.Forms.Padding(2);
            this.cbDuplicado.Name = "cbDuplicado";
            this.cbDuplicado.Size = new System.Drawing.Size(74, 17);
            this.cbDuplicado.TabIndex = 18;
            this.cbDuplicado.Text = "Duplicado";
            this.cbDuplicado.UseVisualStyleBackColor = true;
            // 
            // cbGroup2
            // 
            this.cbGroup2.AutoSize = true;
            this.cbGroup2.Location = new System.Drawing.Point(322, 228);
            this.cbGroup2.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup2.Name = "cbGroup2";
            this.cbGroup2.Size = new System.Drawing.Size(79, 17);
            this.cbGroup2.TabIndex = 19;
            this.cbGroup2.Text = "Grupo de 2";
            this.cbGroup2.UseVisualStyleBackColor = true;
            // 
            // cbGroup4
            // 
            this.cbGroup4.AutoSize = true;
            this.cbGroup4.Location = new System.Drawing.Point(322, 271);
            this.cbGroup4.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup4.Name = "cbGroup4";
            this.cbGroup4.Size = new System.Drawing.Size(79, 17);
            this.cbGroup4.TabIndex = 20;
            this.cbGroup4.Text = "Grupo de 4";
            this.cbGroup4.UseVisualStyleBackColor = true;
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(323, 9);
            this.cbTodos.Margin = new System.Windows.Forms.Padding(2);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(56, 17);
            this.cbTodos.TabIndex = 21;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // cbGroup3
            // 
            this.cbGroup3.AutoSize = true;
            this.cbGroup3.Location = new System.Drawing.Point(322, 249);
            this.cbGroup3.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup3.Name = "cbGroup3";
            this.cbGroup3.Size = new System.Drawing.Size(79, 17);
            this.cbGroup3.TabIndex = 22;
            this.cbGroup3.Text = "Grupo de 3";
            this.cbGroup3.UseVisualStyleBackColor = true;
            // 
            // cbGroup5
            // 
            this.cbGroup5.AutoSize = true;
            this.cbGroup5.Location = new System.Drawing.Point(322, 292);
            this.cbGroup5.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup5.Name = "cbGroup5";
            this.cbGroup5.Size = new System.Drawing.Size(79, 17);
            this.cbGroup5.TabIndex = 23;
            this.cbGroup5.Text = "Grupo de 5";
            this.cbGroup5.UseVisualStyleBackColor = true;
            // 
            // cbGroup6
            // 
            this.cbGroup6.AutoSize = true;
            this.cbGroup6.Location = new System.Drawing.Point(322, 313);
            this.cbGroup6.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup6.Name = "cbGroup6";
            this.cbGroup6.Size = new System.Drawing.Size(79, 17);
            this.cbGroup6.TabIndex = 24;
            this.cbGroup6.Text = "Grupo de 6";
            this.cbGroup6.UseVisualStyleBackColor = true;
            // 
            // cbGroup7
            // 
            this.cbGroup7.AutoSize = true;
            this.cbGroup7.Location = new System.Drawing.Point(322, 334);
            this.cbGroup7.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup7.Name = "cbGroup7";
            this.cbGroup7.Size = new System.Drawing.Size(79, 17);
            this.cbGroup7.TabIndex = 25;
            this.cbGroup7.Text = "Grupo de 7";
            this.cbGroup7.UseVisualStyleBackColor = true;
            // 
            // FormLotofacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 508);
            this.Controls.Add(this.cbGroup7);
            this.Controls.Add(this.cbGroup6);
            this.Controls.Add(this.cbGroup5);
            this.Controls.Add(this.cbGroup3);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.cbGroup4);
            this.Controls.Add(this.cbGroup2);
            this.Controls.Add(this.cbDuplicado);
            this.Controls.Add(this.cbInvertido);
            this.Controls.Add(this.cbNormal);
            this.Controls.Add(this.cbOddEven);
            this.Controls.Add(this.cbPrimeNumber);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbSum);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.cbLine);
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
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbColumn;
        private System.Windows.Forms.CheckBox cbSum;
        private System.Windows.Forms.CheckBox cbPosition;
        private System.Windows.Forms.CheckBox cbPrimeNumber;
        private System.Windows.Forms.CheckBox cbOddEven;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbInvertido;
        private System.Windows.Forms.CheckBox cbDuplicado;
        private System.Windows.Forms.CheckBox cbGroup2;
        private System.Windows.Forms.CheckBox cbGroup4;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.CheckBox cbGroup3;
        private System.Windows.Forms.CheckBox cbGroup5;
        private System.Windows.Forms.CheckBox cbGroup6;
        private System.Windows.Forms.CheckBox cbGroup7;
    }
}