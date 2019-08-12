using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtDate_DoubleClick(object sender, EventArgs e)
        {
            DateTime date; // declare a variable to hold the input from the box
            string dateFinal = DateTime.TryParse(txtDate.Text, out date) ? date.ToLongDateString() : "Cannot convert";
            lbldate.Text = dateFinal;
        }
    }
}
