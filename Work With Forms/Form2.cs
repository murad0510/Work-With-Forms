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
        List<Product> textList = new List<Product>();

        Product product = new Product();

        private string name;

        public string Name
        {
            get { return name; }
            set { product.Name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { product.Description = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { product.Price = value; }
        }
        public Form2()
        {
            InitializeComponent();
            textList.Add(product);
            listBox1.Items.Add(textList.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
