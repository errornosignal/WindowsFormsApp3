using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public bool TryGetPrice(char type, out decimal price)
        {
            switch (type)
            {
                case 'R':
                case 'r':
                    price = 1.5m;
                    return true;
                case 'G':
                case 'g':
                    price = 2.0m;
                    return true;
                case 'B':
                case 'b':
                    price = 2.5m;
                    return true;
                default:
                    price = 0.0m;
                    return false;
            }
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            var quantity = int.Parse(this.QtyTextBox.Text);
            var type = char.Parse(this.TypeTextBox.Text);
            var isValidType = this.TryGetPrice(type, out decimal pricePer);
            var total = pricePer * Convert.ToDecimal(quantity);
            this.TotalTextBox.Text = total.ToString("G");
            this.PayButton.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            var total = decimal.Parse(this.TotalTextBox.Text);
            var pay = decimal.Parse(this.PayMaskedTextBox.Text);

            var change = pay - total;

            this.ChangeLabel.Text = change.ToString("C");
        }
    }
}
