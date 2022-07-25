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
            this.cbMetodo65 = new System.Windows.Forms.CheckBox();
            this.cbFinais = new System.Windows.Forms.CheckBox();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFechamentos
            // 
            this.txtFechamentos.Location = new System.Drawing.Point(23, 11);
            this.txtFechamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechamentos.Multiline = true;
            this.txtFechamentos.Name = "txtFechamentos";
            this.txtFechamentos.ReadOnly = true;
            this.txtFechamentos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFechamentos.Size = new System.Drawing.Size(396, 452);
            this.txtFechamentos.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 470);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(511, 28);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Carregar Resultados";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisar.Location = new System.Drawing.Point(16, 575);
            this.btnAnalisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(511, 47);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(16, 507);
            this.txtSaveFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.ReadOnly = true;
            this.txtSaveFilePath.Size = new System.Drawing.Size(511, 22);
            this.txtSaveFilePath.TabIndex = 3;
            // 
            // btnCarregarLocalPath
            // 
            this.btnCarregarLocalPath.Location = new System.Drawing.Point(16, 539);
            this.btnCarregarLocalPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregarLocalPath.Name = "btnCarregarLocalPath";
            this.btnCarregarLocalPath.Size = new System.Drawing.Size(511, 28);
            this.btnCarregarLocalPath.TabIndex = 4;
            this.btnCarregarLocalPath.Text = "Carregar Local Path";
            this.btnCarregarLocalPath.UseVisualStyleBackColor = true;
            this.btnCarregarLocalPath.Click += new System.EventHandler(this.btnCarregarLocalPath_Click);
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.Location = new System.Drawing.Point(431, 38);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(72, 21);
            this.cbLine.TabIndex = 5;
            this.cbLine.Text = "Linhas";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // cbColumn
            // 
            this.cbColumn.AutoSize = true;
            this.cbColumn.Location = new System.Drawing.Point(431, 65);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(81, 21);
            this.cbColumn.TabIndex = 6;
            this.cbColumn.Text = "Colunas";
            this.cbColumn.UseVisualStyleBackColor = true;
            // 
            // cbSum
            // 
            this.cbSum.AutoSize = true;
            this.cbSum.Location = new System.Drawing.Point(431, 92);
            this.cbSum.Name = "cbSum";
            this.cbSum.Size = new System.Drawing.Size(66, 21);
            this.cbSum.TabIndex = 7;
            this.cbSum.Text = "Soma";
            this.cbSum.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.AutoSize = true;
            this.cbPosition.Location = new System.Drawing.Point(431, 119);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(80, 21);
            this.cbPosition.TabIndex = 8;
            this.cbPosition.Text = "Posição";
            this.cbPosition.UseVisualStyleBackColor = true;
            // 
            // cbPrimeNumber
            // 
            this.cbPrimeNumber.AutoSize = true;
            this.cbPrimeNumber.Location = new System.Drawing.Point(431, 146);
            this.cbPrimeNumber.Name = "cbPrimeNumber";
            this.cbPrimeNumber.Size = new System.Drawing.Size(73, 21);
            this.cbPrimeNumber.TabIndex = 9;
            this.cbPrimeNumber.Text = "Primos";
            this.cbPrimeNumber.UseVisualStyleBackColor = true;
            // 
            // cbOddEven
            // 
            this.cbOddEven.AutoSize = true;
            this.cbOddEven.Location = new System.Drawing.Point(431, 173);
            this.cbOddEven.Name = "cbOddEven";
            this.cbOddEven.Size = new System.Drawing.Size(91, 21);
            this.cbOddEven.TabIndex = 12;
            this.cbOddEven.Text = "Impar/Par";
            this.cbOddEven.UseVisualStyleBackColor = true;
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Location = new System.Drawing.Point(430, 199);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(75, 21);
            this.cbNormal.TabIndex = 16;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // cbInvertido
            // 
            this.cbInvertido.AutoSize = true;
            this.cbInvertido.Location = new System.Drawing.Point(430, 226);
            this.cbInvertido.Name = "cbInvertido";
            this.cbInvertido.Size = new System.Drawing.Size(84, 21);
            this.cbInvertido.TabIndex = 17;
            this.cbInvertido.Text = "Invertido";
            this.cbInvertido.UseVisualStyleBackColor = true;
            // 
            // cbDuplicado
            // 
            this.cbDuplicado.AutoSize = true;
            this.cbDuplicado.Location = new System.Drawing.Point(431, 253);
            this.cbDuplicado.Name = "cbDuplicado";
            this.cbDuplicado.Size = new System.Drawing.Size(93, 21);
            this.cbDuplicado.TabIndex = 18;
            this.cbDuplicado.Text = "Duplicado";
            this.cbDuplicado.UseVisualStyleBackColor = true;
            // 
            // cbMetodo65
            // 
            this.cbMetodo65.AutoSize = true;
            this.cbMetodo65.Location = new System.Drawing.Point(430, 280);
            this.cbMetodo65.Name = "cbMetodo65";
            this.cbMetodo65.Size = new System.Drawing.Size(97, 21);
            this.cbMetodo65.TabIndex = 19;
            this.cbMetodo65.Text = "Método 65";
            this.cbMetodo65.UseVisualStyleBackColor = true;
            // 
            // cbFinais
            // 
            this.cbFinais.AutoSize = true;
            this.cbFinais.Location = new System.Drawing.Point(430, 307);
            this.cbFinais.Name = "cbFinais";
            this.cbFinais.Size = new System.Drawing.Size(67, 21);
            this.cbFinais.TabIndex = 20;
            this.cbFinais.Text = "Finais";
            this.cbFinais.UseVisualStyleBackColor = true;
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(431, 11);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(70, 21);
            this.cbTodos.TabIndex = 21;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // FormLotofacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 625);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.cbFinais);
            this.Controls.Add(this.cbMetodo65);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckBox cbMetodo65;
        private System.Windows.Forms.CheckBox cbFinais;
        private System.Windows.Forms.CheckBox cbTodos;
    }
}