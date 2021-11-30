using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            comboBox.Items.Clear();
            listBox.Items.Clear();
            txtnumero.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUbica_Click(object sender, EventArgs e)
        {
            if(txtnumero.Text=="")
            {
                errorProve.SetError(txtnumero, "Agrege un Numero");
                txtnumero.Focus();
                return;
            }
            errorProve.SetError(txtnumero, "");
            int value = int.Parse(txtnumero.Text);
            if(value%2==0)
            {
                comboBox.Items.Add(value);
            }
            else
            {
                listBox.Items.Add(value);
            }
        }
    }
}
