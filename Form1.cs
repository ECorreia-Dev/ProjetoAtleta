using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {

                /* Enviar os dados para a classe */

                obj.Nome = txtNome.Text;
                obj.Altura = double.Parse(txtAltura.Text);
                obj.Idade = int.Parse(txtIdade.Text);
                obj.Peso = double.Parse(txtPeso.Text);

                lblIMC.Text = (obj.CalcularIMC().ToString("0.00"));
                MessageBox.Show(obj.ImprimirDados() +
                    "\nIMC: " + obj.CalcularIMC().ToString("0.00"));

            }

            /* Tratamento de exceções */

            catch (FormatException ex)
            {
                MessageBox.Show("Me desculpe, ocorreu um erro.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
