using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricfigures
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            Text = "Risui";
            graphics = DrawPanel.CreateGraphics();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var tb1 = textBox1.Text;
                var fp = tb1.Split();
                int x1 = Convert.ToInt32(fp[0]);
                int y1 = Convert.ToInt32(fp[1]);

                var tb2 = textBox2.Text;
                var lp = tb2.Split();
                int x2 = Convert.ToInt32(lp[0]);
                int y2 = Convert.ToInt32(lp[1]);

                Point firstPoint = new Point(x1, y1);
                Point lastPoint = new Point(x2, y2);

                
                var pen = new Pen(Color.Purple, 5);

                graphics.DrawLine(pen, firstPoint, lastPoint);
            }

            catch (Exception)
            { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
    }
}
