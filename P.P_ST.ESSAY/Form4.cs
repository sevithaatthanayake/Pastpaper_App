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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 next = new Form5();
            next.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            Form3 next = new Form3();
            next.Show();
        }
    }
}
