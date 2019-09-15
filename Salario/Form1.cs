using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalulcar_Click(object sender, EventArgs e)
        {
            double horas = double.Parse(txthoras.Text);
            double valor = double.Parse(txtvalor.Text);
            double total = valor * horas;
            double diez = total * 0.10;
            double cinco = total * 0.05;
            double dos = total * 0.02; 
            

            if (total < 700000)
            {
                total = total + diez;
                lbltotal.Text = (" " + total);
                lbltotal.Visible = true;
                MessageBox.Show("se le incrementó 10% el salario.");
            }
            else
            {
                if (total <= 1000000)
                {
                    total = total - dos;
                    lbltotal.Text = (" " + total);
                    lbltotal.Visible = true;
                    MessageBox.Show("se le decrementó 2% el salario.");
                }
                else
                {
                    if (total >= 1000001)
                    {
                        total = total - cinco + dos;
                        lbltotal.Text = total.ToString();
                        MessageBox.Show("se le decrementó 5% el salario y se le aumentó 2%");
                    }
                }
            }
        }

        
    }

}        