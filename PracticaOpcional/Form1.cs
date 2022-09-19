using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaOpcional
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            clOperaciones operacion1 = new clOperaciones(double.Parse(txtBoxNum1.Text), double.Parse(txtBoxNum2.Text));
            txtBoxResult.Text = operacion1.sumar().ToString();

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            clOperaciones operacion1 = new clOperaciones(double.Parse(txtBoxNum1.Text), double.Parse(txtBoxNum2.Text));
            txtBoxResult.Text = operacion1.restar().ToString();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            clOperaciones operacion1 = new clOperaciones(double.Parse(txtBoxNum1.Text), double.Parse(txtBoxNum2.Text));
            txtBoxResult.Text = operacion1.multiplicar().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            clOperaciones operacion1 = new clOperaciones(double.Parse(txtBoxNum1.Text), double.Parse(txtBoxNum2.Text));
            txtBoxResult.Text = operacion1.dividir().ToString();
        }
    }
}
