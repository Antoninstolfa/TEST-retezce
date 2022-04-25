using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_řetězce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string veta = "";
            char znak = 'a';
            int vyslednaPocitadlo = 0;
            char vyskytZnak = ' ';
            if (checkBox1.Checked)
            {
                veta = "_a_ nam zabili Ferdinanda.";
            }
            if (checkBox2.Checked)
            {
                veta = "Prazdn_ retezec ma hodnotu nebo _tring.Empt_.";
            }
            if (checkBox3.Checked)
            {
                veta = "Inst_nce String je nemenn_.";
            }
            if (checkBox4.Checked)
            {
                veta = "Halda j_ prakticky __om_z__a pam_t.";
            }
            if(veta == "")
            {
                MessageBox.Show("Vyberte větu u které chcete napovědět!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veta.ToLower();
                string[] slova = veta.Split(' ');
                while (znak != '{')
                {
                    int pocitadloZnak = 0;
                    foreach (string pismeno in slova)
                    {
                        if (veta.Contains(znak))
                        {
                            pocitadloZnak++;
                        }
                        else
                        {
                            listBox1.Items.Add(znak);
                            break;
                        }
                        if(pocitadloZnak > vyslednaPocitadlo)
                        {
                            vyslednaPocitadlo = pocitadloZnak;
                            vyskytZnak = znak;
                        }
                    }
                    znak++;
                }
                label5.Text = Convert.ToString(vyskytZnak);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LawnGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pismeno = textBox1.Text;
            pismeno.ToLower();
            if(listBox1.Items.Contains(pismeno))
            {
                MessageBox.Show("Tato možnost může být správně!", "Gratulujeme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Tato možnost není správně!", "Upsík dupsík!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
