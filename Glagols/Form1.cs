using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glagols
{
    public partial class Form1 : Form
    {
        List<glagol> gs;
        public Form1()
        {
            InitializeComponent();
            gs = new List<glagol>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            glagol g = new glagol(textBox1.Text, textBox2.Text,textBox3.Text);
            if (checkBox1.Checked) g.regular = false;
            gs.Add(g);
          
            textBox2.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (glagol g in gs)
                listBox1.Items.Add(g.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (glagol g in gs)
                if (g.First == g.Second && g.Second == g.Third)
                    listBox1.Items.Add(g.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gs.Sort(glagol.compare);
            listBox1.Items.Clear();
            foreach (glagol g in gs)
                if (g.regular)
                    listBox1.Items.Add(g.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gs.Sort(glagol.compare);
            listBox1.Items.Clear();
            foreach (glagol g in gs)
                if (!g.regular)
                    listBox1.Items.Add(g.ToString());
        }
    }
    public struct glagol
    {
        public Boolean regular;
        public string First;
        public string Second;
        public string Third;

        public glagol(string s1, string s2, string s3, Boolean r = true)
        {
            First = s1;
            Second = s2;
            Third = s3;
            regular = r;
        }

        public override string ToString()
        {
            return First + " " + Second + " " + Third;
        }
        public static int compare(glagol g1, glagol g2)
            {
            return String.Compare(g1.First, g2.First);
            }
    }
}
