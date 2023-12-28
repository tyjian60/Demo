using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person me, friend;
        public Form1()
        {
            InitializeComponent();

            borrowButton.Enabled = false;
            repayButton.Enabled = false;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            me.borrow(friend, 1000);
            updateMoney();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            me.repay(friend, 1000);
            updateMoney();
        }

        private void updateMoney()
        {
            myMoneyLebel.Text = "" + me.money;
            friendMoneyLebel.Text = "" + friend.money;            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            me = new Person(myNameTextBox.Text, 2000);
            friend = new Person(friendNameTextBox.Text, 10000);

            myNameTextBox.Enabled = false;
            friendNameTextBox.Enabled = false;
            confirmButton.Enabled = false;

            myNameLebel.Text = me.name;
            friendNameLebel.Text = friend.name;
            borrowButton.Text = "跟 " + friend.name + " 借 1000$";
            repayButton.Text = "還給 " + friend.name + " 1000$";

            borrowButton.Enabled = true;
            repayButton.Enabled = true;


        }
    }
}
