using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = "你已經點了... " + count + " 下"; 
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            count = 0;
            countLabel.Text = "你已經點了... " + count + " 下";
        }
    }
}
