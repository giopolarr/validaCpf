namespace atividade1___IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.CALCULAR = new System.Windows.Forms.Label();
            this.tx_botao = new System.Windows.Forms.Button();
            this.tx_peso = new System.Windows.Forms.NumericUpDown();
            this.tx_altura = new System.Windows.Forms.NumericUpDown();
            this.tx_idade = new System.Windows.Forms.NumericUpDown();
            this.tx_sexo = new System.Windows.Forms.ComboBox();
            this.tx_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tx_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_idade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "altura";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(97, 47);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(161, 20);
            this.tx_nome.TabIndex = 6;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(97, 93);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(161, 20);
            this.tx_cpf.TabIndex = 7;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(63, 320);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(113, 23);
            this.bt_calcular.TabIndex = 12;
            this.bt_calcular.Text = "calcular imc";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // CALCULAR
            // 
            this.CALCULAR.AutoSize = true;
            this.CALCULAR.Location = new System.Drawing.Point(317, 20);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(85, 13);
            this.CALCULAR.TabIndex = 13;
            this.CALCULAR.Text = "CALCULAR IMC";
            // 
            // tx_botao
            // 
            this.tx_botao.Location = new System.Drawing.Point(216, 320);
            this.tx_botao.Name = "tx_botao";
            this.tx_botao.Size = new System.Drawing.Size(75, 23);
            this.tx_botao.TabIndex = 14;
            this.tx_botao.Text = "cancelar";
            this.tx_botao.UseVisualStyleBackColor = true;
            this.tx_botao.Click += new System.EventHandler(this.tx_botao_Click);
            // 
            // tx_peso
            // 
            this.tx_peso.Location = new System.Drawing.Point(93, 224);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(120, 20);
            this.tx_peso.TabIndex = 15;
            // 
            // tx_altura
            // 
            this.tx_altura.DecimalPlaces = 2;
            this.tx_altura.Location = new System.Drawing.Point(97, 269);
            this.tx_altura.Name = "tx_altura";
            this.tx_altura.Size = new System.Drawing.Size(120, 20);
            this.tx_altura.TabIndex = 16;
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(97, 137);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(120, 20);
            this.tx_idade.TabIndex = 17;
            // 
            // tx_sexo
            // 
            this.tx_sexo.FormattingEnabled = true;
            this.tx_sexo.Items.AddRange(new object[] {
            "masculino",
            "feminino",
            "outros"});
            this.tx_sexo.Location = new System.Drawing.Point(97, 179);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(121, 21);
            this.tx_sexo.TabIndex = 18;
            // 
            // tx_resultado
            // 
            this.tx_resultado.AutoSize = true;
            this.tx_resultado.Location = new System.Drawing.Point(378, 242);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(9, 13);
            this.tx_resultado.TabIndex = 19;
            this.tx_resultado.Text = "l";
            this.tx_resultado.Click += new System.EventHandler(this.tx_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_altura);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.tx_botao);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULAR IMC";
            ((System.ComponentModel.ISupportInitialize)(this.tx_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label CALCULAR;
        private System.Windows.Forms.Button tx_botao;
        private System.Windows.Forms.NumericUpDown tx_peso;
        private System.Windows.Forms.NumericUpDown tx_altura;
        private System.Windows.Forms.NumericUpDown tx_idade;
        private System.Windows.Forms.ComboBox tx_sexo;
        private System.Windows.Forms.Label tx_resultado;
    }
}

