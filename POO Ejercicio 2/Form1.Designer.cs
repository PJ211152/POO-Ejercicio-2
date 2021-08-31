namespace POO_Ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rb_Gerente = new System.Windows.Forms.RadioButton();
            this.rb_SubGerente = new System.Windows.Forms.RadioButton();
            this.rb_Secretaria = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_SalarioBruto = new System.Windows.Forms.Label();
            this.lbl_MontoDescuento = new System.Windows.Forms.Label();
            this.lbl_SalarioNeto = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apeliidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(280, 297);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(107, 28);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // rb_Gerente
            // 
            this.rb_Gerente.AutoSize = true;
            this.rb_Gerente.Location = new System.Drawing.Point(460, 159);
            this.rb_Gerente.Name = "rb_Gerente";
            this.rb_Gerente.Size = new System.Drawing.Size(63, 17);
            this.rb_Gerente.TabIndex = 1;
            this.rb_Gerente.TabStop = true;
            this.rb_Gerente.Text = "Gerente";
            this.rb_Gerente.UseVisualStyleBackColor = true;
            // 
            // rb_SubGerente
            // 
            this.rb_SubGerente.AutoSize = true;
            this.rb_SubGerente.Location = new System.Drawing.Point(460, 182);
            this.rb_SubGerente.Name = "rb_SubGerente";
            this.rb_SubGerente.Size = new System.Drawing.Size(82, 17);
            this.rb_SubGerente.TabIndex = 2;
            this.rb_SubGerente.TabStop = true;
            this.rb_SubGerente.Text = "SubGerente";
            this.rb_SubGerente.UseVisualStyleBackColor = true;
            // 
            // rb_Secretaria
            // 
            this.rb_Secretaria.AutoSize = true;
            this.rb_Secretaria.Location = new System.Drawing.Point(460, 205);
            this.rb_Secretaria.Name = "rb_Secretaria";
            this.rb_Secretaria.Size = new System.Drawing.Size(73, 17);
            this.rb_Secretaria.TabIndex = 3;
            this.rb_Secretaria.TabStop = true;
            this.rb_Secretaria.Text = "Secretaria";
            this.rb_Secretaria.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(460, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // lbl_SalarioBruto
            // 
            this.lbl_SalarioBruto.AutoSize = true;
            this.lbl_SalarioBruto.Location = new System.Drawing.Point(88, 159);
            this.lbl_SalarioBruto.Name = "lbl_SalarioBruto";
            this.lbl_SalarioBruto.Size = new System.Drawing.Size(66, 13);
            this.lbl_SalarioBruto.TabIndex = 9;
            this.lbl_SalarioBruto.Text = "Salario bruto";
            // 
            // lbl_MontoDescuento
            // 
            this.lbl_MontoDescuento.AutoSize = true;
            this.lbl_MontoDescuento.Location = new System.Drawing.Point(89, 185);
            this.lbl_MontoDescuento.Name = "lbl_MontoDescuento";
            this.lbl_MontoDescuento.Size = new System.Drawing.Size(105, 13);
            this.lbl_MontoDescuento.TabIndex = 10;
            this.lbl_MontoDescuento.Text = "Monto de descuento";
            // 
            // lbl_SalarioNeto
            // 
            this.lbl_SalarioNeto.AutoSize = true;
            this.lbl_SalarioNeto.Location = new System.Drawing.Point(89, 211);
            this.lbl_SalarioNeto.Name = "lbl_SalarioNeto";
            this.lbl_SalarioNeto.Size = new System.Drawing.Size(65, 13);
            this.lbl_SalarioNeto.TabIndex = 11;
            this.lbl_SalarioNeto.Text = "Salario Neto";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(81, 77);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 12;
            this.lbl_Nombres.Text = "Nombres";
            this.lbl_Nombres.Click += new System.EventHandler(this.lbl_Nombre_Click);
            // 
            // lbl_Apeliidos
            // 
            this.lbl_Apeliidos.AutoSize = true;
            this.lbl_Apeliidos.Location = new System.Drawing.Point(405, 77);
            this.lbl_Apeliidos.Name = "lbl_Apeliidos";
            this.lbl_Apeliidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Apeliidos.TabIndex = 13;
            this.lbl_Apeliidos.Text = "Apellidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 357);
            this.Controls.Add(this.lbl_Apeliidos);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_SalarioNeto);
            this.Controls.Add(this.lbl_MontoDescuento);
            this.Controls.Add(this.lbl_SalarioBruto);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_Secretaria);
            this.Controls.Add(this.rb_SubGerente);
            this.Controls.Add(this.rb_Gerente);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rb_Gerente;
        private System.Windows.Forms.RadioButton rb_SubGerente;
        private System.Windows.Forms.RadioButton rb_Secretaria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_SalarioBruto;
        private System.Windows.Forms.Label lbl_MontoDescuento;
        private System.Windows.Forms.Label lbl_SalarioNeto;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apeliidos;
    }
}

