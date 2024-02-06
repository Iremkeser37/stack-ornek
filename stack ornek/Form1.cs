using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_ornek
{
    public partial class Form1 : Form
    {
        Stack<string> musteri = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir(Label lbl)
        {
            if (musteri.Count > 0)
            {
                lbl.Text = musteri.Pop();
            }
            else
            {
                MessageBox.Show("işiniz bitti");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Push("irem");
            musteri.Push("ömer");
            musteri.Push("emre");
            musteri.Push("birgül");
            musteri.Push("özgür");
            musteri.Push("ceren");
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            musteri.Push(txtAd.Text);
        }

        private void btnGetir1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSıra1);
        }

        private void btnGetir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSıra2);
        }

        private void btnGetir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSıra3);
        }
    }
}
