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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 next = new Form6();
            next.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4  next = new Form4 ();
            next.Show();
        }
    }
}
