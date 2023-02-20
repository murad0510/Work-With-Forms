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
            NameTxtL.Text = form.pro.Name;
            DescriptionTxtL.Text = form.pro.Description;
            PriceTxtL.Text = form.pro.Price.ToString();
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

        public void TextClear()
        {
            NameTxtL.Text = string.Empty;
            DescriptionTxtL.Text = string.Empty;
            PriceTxtL.Text = string.Empty;
        }

        Form2 form = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = NameTxtL.Text;
            product.Description = DescriptionTxtL.Text;
            product.Price = decimal.Parse(PriceTxtL.Text);
            form.Product = product;
            TextClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Handler = IsClick;
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.pro.Name = NameTxtL.Text;
            form.pro.Description = DescriptionTxtL.Text;
            form.pro.Price = decimal.Parse(PriceTxtL.Text);
            TextClear();
        }
    }
}