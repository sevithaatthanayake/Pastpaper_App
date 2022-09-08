using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.P_ST.ESSAY
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 next = new Form7();
            next.Show();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 next = new Form5();
            next.Show();
        }
    }
}
