using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtb_MontoDescuento.Enabled = false;
            txtb_SalarioNeto.Enabled = false;
            rb_Gerente.Checked = true;
        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtb_SalarioBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_Gerente_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Gerente.Enabled == true)
            {
                txtb_MontoDescuento.Text = "20%";
            }
        }

        private void rb_SubGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SubGerente.Enabled == true)
            {
                txtb_MontoDescuento.Text = "15%";
            }
        }

        private void rb_Secretaria_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_Secretaria.Enabled == true)
            {
                txtb_MontoDescuento.Text = "5%";
                
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double descuento=0, salneto, salbruto;
            string n, a;

            try
            {
                if(txtb_Nombres.Text.Length !=0 && txtb_Apellidos.Text.Length != 0)
                {
                    if (rb_Gerente.Checked == true)
                    {
                        descuento = 0.2;
                    }

                    if (rb_SubGerente.Checked == true)
                    {
                        descuento = 0.15;
                    }

                    if (rb_Secretaria.Checked == true)
                    {
                        descuento = 0.05;
                    }

                    salbruto = double.Parse(txtb_SalarioBruto.Text);
                    salneto = -(descuento * salbruto) + salbruto;
                    txtb_SalarioNeto.Text = Convert.ToString(salneto);
                    n = txtb_Nombres.Text;
                    a = txtb_Apellidos.Text;
                }
                else
                {
                    MessageBox.Show("Porfavor ingrese nombres y apellidos");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }
    }
}
