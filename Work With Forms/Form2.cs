using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            listBox1.Items.Add(value);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changed = listBox1.SelectedItem as Product;
            pro = changed;
            Handler.Invoke(sender, e);
        }
    }
}
