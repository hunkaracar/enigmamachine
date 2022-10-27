using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmamethodX1.models;

namespace EnigmamethodX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sifrefonks new_sifre = new sifrefonks();

        private void button1_Click(object sender, EventArgs e)
        {
            cozumlebox.Text = new_sifre.Sifrele(sifrelebox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifrelebox.Text = new_sifre.Cozumle(cozumlebox.Text);
        }

    }   
}
