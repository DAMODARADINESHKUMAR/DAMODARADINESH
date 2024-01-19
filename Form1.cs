using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fast_food_billing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            Datelbl2.Text = DateTime.Now.ToLongDateString();
            timer1.Start();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void Friescb_CheckedChanged(object sender, EventArgs e)
        {
            if (Friescb.Checked == true)
            {
                Friestb.Enabled = true;

            }
            if (Friescb.Checked == false)
            {
                Friestb.Enabled = false;
                Friestb.Text = "0";
            }
        }

        private void Saladcb_CheckedChanged(object sender, EventArgs e)
        {

            if (Saladcb.Checked == true)
            {
                Saladtb.Enabled = true;

            }
            if (Saladcb.Checked == false)
            {
                Saladtb.Enabled = false;
                Saladtb.Text = "0";
            }

        }

        private void Sandichcb_CheckedChanged(object sender, EventArgs e)
        {

            if (Sandichcb.Checked == true)
            {
                Sandwichtb.Enabled = true;

            }
            if (Sandichcb.Checked == false)
            {
                Sandwichtb.Enabled = false;
                Sandwichtb.Text = "0";
            }
        }

        private void Chickencb_CheckedChanged(object sender, EventArgs e)
        {

            if (Chickencb.Checked == true)
            {
                Chickentb.Enabled = true;

            }
            if (Chickencb.Checked == false)
            {
                Chickentb.Enabled = false;
                Chickentb.Text = "0";
            }
        }

        private void Cheesecb_CheckedChanged(object sender, EventArgs e)
        {

            if (Cheesecb.Checked == true)
            {
                Cheesetb.Enabled = true;

            }
            if (Cheesecb.Checked == false)
            {
                Cheesetb.Enabled = false;
                Cheesetb.Text = "0";
            }
        }

        private void Burgetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Burgercb_CheckedChanged(object sender, EventArgs e)
        {

            if (Burgercb.Checked == true)
            {
                Burgertb.Enabled = true;

            }
            if (Burgercb.Checked == false)
            {
                Burgertb.Enabled = false;
                Burgertb.Text = "0";
            }

        }

        private void Teacb_CheckedChanged(object sender, EventArgs e)
        {

            if (Teacb.Checked == true)
            {
                Teatb.Enabled = true;

            }
            if (Burgercb.Checked == false)
            {
                Teatb.Enabled = false;
                Teatb.Text = "0";
            }
        }

        private void Chocolatecb_CheckedChanged(object sender, EventArgs e)
        {
            if (Chocolatecb.Checked == true)
            {
                Chocolatetb.Enabled = true;

            }
            if (Chocolatecb.Checked == false)
            {
                Chocolatetb.Enabled = false;
                Chocolatetb.Text = "0";
            }
        }

        private void Bottlecb_CheckedChanged(object sender, EventArgs e)
        {

            if (Watercb.Checked == true)
            {
                Watertb.Enabled = true;

            }
            if (Watercb.Checked == false)
            {
                Watertb.Enabled = false;
                Watertb.Text = "0";
            }
        }

        private void Colacb_CheckedChanged(object sender, EventArgs e)
        {

            if (Colacb.Checked == true)
            {
                Colatb.Enabled = true;

            }
            if (Colacb.Checked == false)
            {
                Colatb.Enabled = false;
                Colatb.Text = "0";
            }
        }

        private void Pancakescb_CheckedChanged(object sender, EventArgs e)
        {

            if (Pancakescb.Checked == true)
            {
                Pancaketb.Enabled = true;

            }
            if (Pancakescb.Checked == false)
            {
                Pancaketb.Enabled = false;
                Pancaketb.Text = "0";
            }
        }

        private void Orangecb_CheckedChanged(object sender, EventArgs e)
        {

            if (Orangecb.Checked == true)
            {
                Orangetb.Enabled = true;

            }
            if (Orangecb.Checked == false)
            {
                Orangetb.Enabled = false;
                Orangetb.Text = "0";
            }
        }

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Friescb.Checked = false;
            Burgercb.Checked = false;
            Saladcb.Checked = false;
            Sandichcb.Checked = false;
            Chickencb.Checked = false;
            Cheesecb.Checked = false;
            Teacb.Checked = false;
            Watercb.Checked = false;
            Chocolatecb.Checked = false;
            Pancakescb.Checked = false;
            Orangecb.Checked = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //declare unit prices to meals and drinks
        double Friesup = 90, Burgerup = 100, Saladup = 80, Sandwichup = 100, Cheeseup = 90, Chickenup = 200;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Receipttb.Text + "Subtotal" + Subtotallbl.Text + " Tax:" + Taxlbl.Text + "Grand Total" + Grandtotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Grandtotallbl_Click(object sender, EventArgs e)
        {

        }

        double Waterup = 20, Teaup = 10, Colaup = 20, Chocolateup = 60, Pancakeup = 50, Orangeup = 40;
        //declare
        double Friestp, Burgertp, Saladtp, Sandwichtp, Cheesetp ,Chickentp,
         Watertp, Teatp, Colatp, Chocolatetp, Pancaketp, Orangetp;
        double subtotal = 0, Tax=0, Grandtotal =0;
        private void button2_Click(object sender, EventArgs e)
        {
            Friestp = Friesup * Convert.ToDouble(Friestb.Text);
            Burgertp = Burgerup * Convert.ToDouble(Burgertb.Text);
            Saladtp = Saladup * Convert.ToDouble(Saladtb.Text);
            Sandwichtp = Sandwichup * Convert.ToDouble(Sandwichtb.Text);
            Cheesetp = Cheeseup * Convert.ToDouble(Cheesetb.Text);
            Chickentp = Chickenup * Convert.ToDouble(Chickentb.Text);
            //drinks and waters
            Watertp = Waterup * Convert.ToDouble(Watertb.Text);
            Teatp = Teaup * Convert.ToDouble(Teatb.Text);
            Colatp = Colaup * Convert.ToDouble(Colatb.Text);
            Chocolatetp = Chocolateup * Convert.ToDouble(Chocolatetb.Text);
            Pancaketp = Pancakeup * Convert.ToDouble(Pancaketb.Text);
            Orangetp = Orangeup * Convert.ToDouble(Orangetb.Text);
            //now lets print receipt
            Receipttb.Clear();
            subtotal = 0;
            Tax = 0;
            Grandtotal = 0;
            
            Receipttb.AppendText(Environment.NewLine);
            Receipttb.AppendText("\t\t\t HELLO RESTURENT WELCOME TO HYDERBAD ENJOY \t" + Datelbl.Text+ Environment.NewLine);
            Receipttb.AppendText("\t\t\t**************************************" + Environment.NewLine);
            if(Friescb.Checked==true)
            {
                Receipttb.AppendText("\t Fries:\t" + Friestp + "RS" + Environment.NewLine);
                subtotal = subtotal + Friestp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Burgercb.Checked == true)
            {
                Receipttb.AppendText("\t Burger:\t" + Burgertp + "RS" + Environment.NewLine);
                subtotal = subtotal + Burgertp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Chickencb.Checked == true)
            {
                Receipttb.AppendText("\t Chicken:\t" + Chickentp + "RS" + Environment.NewLine);
                subtotal = subtotal + Chickentp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Cheesecb.Checked == true)
            {
                Receipttb.AppendText("\t Cheese:\t" + Cheesetp + "RS" + Environment.NewLine);
                subtotal = subtotal + Cheesetp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Saladcb.Checked == true)
            {
                Receipttb.AppendText("\t Salad:\t" + Saladtp + "RS" + Environment.NewLine);
                subtotal = subtotal + Saladtp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Sandichcb.Checked == true)
            {
                Receipttb.AppendText("\t Sandwich:\t" + Sandwichtp + "RS" + Environment.NewLine);
                subtotal = subtotal + Sandwichtp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            //drinks
            if (Teacb.Checked == true)
            {
                Receipttb.AppendText("\t Tea:\t" + Teatp + "RS" + Environment.NewLine);
                subtotal = subtotal + Teatp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Colacb.Checked == true)
            {
                Receipttb.AppendText("\t Cola:\t" + Colatp + "RS" + Environment.NewLine);
                subtotal = subtotal + Colatp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Chocolatecb.Checked == true)
            {
                Receipttb.AppendText("\t Chocolate:\t" + Chocolatetp + "RS" + Environment.NewLine);
                subtotal = subtotal + Chocolatetp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Watercb.Checked == true)
            {
                Receipttb.AppendText("\t Water:\t" + Watertp + "RS" + Environment.NewLine);
                subtotal = subtotal + Watertp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Pancakescb.Checked == true)
            {
                Receipttb.AppendText("\t Pan cakes:\t" + Pancaketp + "RS" + Environment.NewLine);
                subtotal = subtotal + Pancaketp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            if (Orangecb.Checked == true)
            {
                Receipttb.AppendText("\t Orange:\t" + Orangetp + "RS" + Environment.NewLine);
                subtotal = subtotal + Orangetp;
                Subtotallbl.Text = " " + subtotal;
            }
            Receipttb.AppendText("\t\t" + Environment.NewLine);
            Tax = subtotal * 0.16;
            Grandtotal = subtotal + Tax;
            Taxlbl.Text = "RS" + Tax;
            Grandtotallbl.Text = "RS" + Grandtotal;

        }
    }

    }

