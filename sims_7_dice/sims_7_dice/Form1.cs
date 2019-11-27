using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_7_dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] p1 = { 1,1,1,1,1,1};
        double[] p2 = { 0.1, 0.1, 0.1, 0.2, 0.2, 0.3 };
        Random rnd = new Random();
        double alpha1, alpha2;
        int i1 = 0, i2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            c();
            alpha1 = rnd.NextDouble() * 6;
            alpha2 = rnd.NextDouble();
            alpha1 = s(p1, alpha1);
            alpha2 = s(p2, alpha2);
            first.Text = alpha1.ToString();
            second.Text = alpha2.ToString();
            if (alpha1 > alpha2)
            {
                T("First player win");
                i1++;
            }
            else if (alpha1 < alpha2)
            {
                T("Second player win");
                i2++;
            }
            else
                T("Draw");
            label1.Text = i1.ToString();
            label2.Text = i2.ToString();
        }

        private void T(string v)
        {
            win.Text = v;
            win.Visible = true;
        }

        private int s(double[] p, double alpha)
        {
            int k = 0;
            while (alpha>0)
            {
                alpha -= p[k];
                k++;
            }
            return k;
        }

        private void c()
        {
            first.Text = "";
            second.Text = "";
            win.Visible = false;
        }
    }
}
