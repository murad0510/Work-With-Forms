using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_With_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
        //                                                          Color.FromArgb(245, 133, 73),
        //                                                          Color.FromArgb(108, 45, 26),
        //                                                          45F))
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}


        Form2 form = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            form.Name = textBox1.Text;
            form.Description = textBox2.Text;
            form.Price = decimal.Parse(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }
    }
}