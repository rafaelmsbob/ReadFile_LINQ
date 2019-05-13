using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadFileLinq
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>(16);
        StreamReader inputfile;
        const int size = 7;
        string[] tokens = new string[size];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var queryCitySearch =
                from cust in customers
                where cust.getcity == "Seattle"
                orderby cust.getlname ascending
                select cust;

            ltbOutput.Items.Clear();
            ltbOutput.Items.Add("Customer List in Seattle ordered by Last name");
            ltbOutput.Items.Add("");

            foreach (Customer cust in queryCitySearch)
            {
                ltbOutput.Items.Add(cust.getlname + "\t" + cust.getname + "\t" + cust.getID + "\t" + cust.getcity);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char[] delim = { ',' };
            inputfile = File.OpenText("CostumersInfo.txt");
            string line;
            int i = 0;

            while (!inputfile.EndOfStream)
            {
                line = inputfile.ReadLine();
                tokens = line.Split(delim);                
                customers.Add(new Customer(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6]));
                i++;                
            }

            ltbOutput.Items.Clear();

            

            //for (int j = 0;j < customers.Count;j++)
            //{
                for (int k = 0; k<7;k++)
                {
                    ltbOutput.Items.Add(customers[k].getlname);
                }

                
            //}
            
                    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var custQuery =
                from cust in customers
                group cust by cust.getcity into custGroup
                where custGroup.Count() > 1
                orderby custGroup.Key
                select custGroup;

            ltbOutput.Items.Clear();
            ltbOutput.Items.Add("Group of Customers where there's more than 1 customer");
            ltbOutput.Items.Add("");

            foreach (var custgroup in custQuery)
            {
                ltbOutput.Items.Add(custgroup.Key);
                ltbOutput.Items.Add("");

                foreach (Customer cust in custgroup)
                {
                    ltbOutput.Items.Add(cust.getlname + "\t" + cust.getname + "\t" + cust.getID + "\t" + cust.getcity);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var custandquery =
                from cust in customers
                where cust.getcity == "Seattle" && int.Parse(cust.getbalance) > 100
                orderby cust.getbalance descending
                select cust;

            ltbOutput.Items.Clear();
            ltbOutput.Items.Add("Customer List in Seattle ordered by Last name");
            ltbOutput.Items.Add("");

            foreach (Customer cust in custandquery)
            {
                ltbOutput.Items.Add(cust.getlname + "\t" + cust.getname + "\t" + cust.getID + "\t" + cust.getcity);
            }

        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            string strcity = ttbCity.Text;

            var cityquery =
                from cust in customers
                where cust.getcity == strcity
                orderby cust.getlname ascending
                select cust;

            ltbOutput.Items.Clear();
            ltbOutput.Items.Add("Customer List in " + strcity + " ordered by Last name");
            ltbOutput.Items.Add("");

            if (cityquery.Count() == 0)
            {
                ltbOutput.Items.Clear();
                ltbOutput.Items.Add("No City with that name");
            }
            else
            {
                foreach (Customer cust in cityquery)
                ltbOutput.Items.Add(cust.getlname + "\t" + cust.getcity);
            }
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            var orquery =
                from cust in customers
                where cust.getcity == ttbCity.Text || int.Parse(cust.getbalance) > int.Parse(ttbbalance.Text)
                orderby cust.getlname ascending
                select cust;

            ltbOutput.Items.Clear();
            ltbOutput.Items.Add("Customer Last name      Balance      city");
            ltbOutput.Items.Add("");

            foreach (Customer cust in orquery)
            {
                ltbOutput.Items.Add(cust.getlname + "  " + cust.getbalance +"  " + cust.getcity);
            }            
        }
    }
}
