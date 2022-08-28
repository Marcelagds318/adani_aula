using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORAsozinha
{
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            lblmen.Text =  txtbox1.Text +" bem vinda!"; //declarei a variavel lblmen no data bindings item name, .Text = " "; quer dizer q quero que apareça um texto
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
