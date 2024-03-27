using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form=new Form5();
            form.Show();
        }

       
    }
}
