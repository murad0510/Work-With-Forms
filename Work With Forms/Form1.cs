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
        private EventHandler<EventArgs> IsClick;

        public Form1()
        {
            InitializeComponent();

            IsClick = new EventHandler<EventArgs>(TextChange);

        }

        private void TextChange(object sender, EventArgs e)
        {
            textBox1.Text = form.pro.Name;
            textBox2.Text = form.pro.Description;
            textBox3.Text = form.pro.Price.ToString();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                  Color.FromArgb(245, 133, 73),
                                                                  Color.FromArgb(108, 45, 26),
                                                                  45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        Form2 form = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBox1.Text;
            product.Description = textBox2.Text;
            product.Price = decimal.Parse(textBox3.Text);
            form.Product = product;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Handler = IsClick;
            form.ShowDialog();
        }
    }
}