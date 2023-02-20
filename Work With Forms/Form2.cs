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
    public partial class Form2 : Form
    {
        public Product pro { get; set; }
        public EventHandler<EventArgs> Handler { get; set; }

        List<Product> textList = new List<Product>();
        private Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; SetLabel(value); }
        }

        private void SetLabel(Product value)
        {
            textList.Add(value);
            TextAddListBox.Items.Add(value);
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

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changed = TextAddListBox.SelectedItem as Product;
            pro = changed;
            Handler.Invoke(sender, e);
        }
    }
}
