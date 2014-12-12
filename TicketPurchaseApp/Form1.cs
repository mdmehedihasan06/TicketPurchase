using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        string noOfTicket;
        double ticketAmount;
        double price;
        
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            noOfTicket = textBox2.Text;
            ticketAmount = Convert.ToDouble(textBox2.Text);
            price = ticketAmount * 10;
            MessageBox.Show(name + ", " + "You have to pay" + " " + price + " " + "Taka for the tickets.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " + name + "\nNo of Tickets: " + noOfTicket + "\nTotal Price: " + price + " Taka");
        }
    }
}