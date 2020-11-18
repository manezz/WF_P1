using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKlikHer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advarsel!! " + TbInput.Text);
            TbInput.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbAdvarselsBesked_Click(object sender, EventArgs e)
        {

        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
