namespace Lab02
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moeda100 = new System.Windows.Forms.Label();
            this.moeda50 = new System.Windows.Forms.Label();
            this.moeda25 = new System.Windows.Forms.Label();
            this.moeda10 = new System.Windows.Forms.Label();
            this.moeda05 = new System.Windows.Forms.Label();
            this.moeda01 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor da Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Pago em Dinheiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Troco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(144, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 15);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Moedas Para Troco";
            // 
            // moeda100
            // 
            this.moeda100.AutoSize = true;
            this.moeda100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda100.Location = new System.Drawing.Point(267, 79);
            this.moeda100.Name = "moeda100";
            this.moeda100.Size = new System.Drawing.Size(2, 15);
            this.moeda100.TabIndex = 8;
            // 
            // moeda50
            // 
            this.moeda50.AutoSize = true;
            this.moeda50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda50.Location = new System.Drawing.Point(267, 127);
            this.moeda50.Name = "moeda50";
            this.moeda50.Size = new System.Drawing.Size(2, 15);
            this.moeda50.TabIndex = 9;
            // 
            // moeda25
            // 
            this.moeda25.AutoSize = true;
            this.moeda25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda25.Location = new System.Drawing.Point(267, 170);
            this.moeda25.Name = "moeda25";
            this.moeda25.Size = new System.Drawing.Size(2, 15);
            this.moeda25.TabIndex = 10;
            // 
            // moeda10
            // 
            this.moeda10.AutoSize = true;
            this.moeda10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda10.Location = new System.Drawing.Point(267, 214);
            this.moeda10.Name = "moeda10";
            this.moeda10.Size = new System.Drawing.Size(2, 15);
            this.moeda10.TabIndex = 11;
            // 
            // moeda05
            // 
            this.moeda05.AutoSize = true;
            this.moeda05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda05.Location = new System.Drawing.Point(267, 251);
            this.moeda05.Name = "moeda05";
            this.moeda05.Size = new System.Drawing.Size(2, 15);
            this.moeda05.TabIndex = 12;
            // 
            // moeda01
            // 
            this.moeda01.AutoSize = true;
            this.moeda01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moeda01.Location = new System.Drawing.Point(267, 290);
            this.moeda01.Name = "moeda01";
            this.moeda01.Size = new System.Drawing.Size(2, 15);
            this.moeda01.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Moedas de R$1,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Moedas de R$0,50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Moedas de R$0,25";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Moedas de R$0,10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(332, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Moedas de R$0,05";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(332, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Moedas de R$0,01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.moeda01);
            this.Controls.Add(this.moeda05);
            this.Controls.Add(this.moeda10);
            this.Controls.Add(this.moeda25);
            this.Controls.Add(this.moeda50);
            this.Controls.Add(this.moeda100);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label moeda100;
        private System.Windows.Forms.Label moeda50;
        private System.Windows.Forms.Label moeda25;
        private System.Windows.Forms.Label moeda10;
        private System.Windows.Forms.Label moeda05;
        private System.Windows.Forms.Label moeda01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

