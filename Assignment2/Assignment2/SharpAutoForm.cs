using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// App name - Auto Center, 	
/// Author's name -Digvijay Singh (200334133),	
/// App	CreationDate -01/11/2017,
/// App description -Calculate Pricing and the Trade in allowance of the car
/// </summary>
/// 

    
namespace Assignment2
{
    public partial class SharpAutoForm : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public SharpAutoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// variables
        /// </summary>
        private double stereo= 472.21;
        private double leather = 987.41;
        private double computer = 1741.23;
        private double standard = 0;
        private double pearlized = 345.72;
        private double costomized=599.99;
        private double additional = 0;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this method inputs the value in textboxes radio boxes are checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                additional += standard;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= standard;
                textBox2.Text = Convert.ToString(additional);
            }

        }
        /// <summary>
        /// this method inputs the value in textboxes radio boxes are checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                additional += pearlized;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= pearlized;
                textBox2.Text = Convert.ToString(additional);
            }
        }
        /// <summary>
        /// this method inputs the value in textboxes radio boxes are checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                additional += costomized;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= costomized;
                textBox2.Text = Convert.ToString(additional);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this method validate input data in base price 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxBasePrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                TextBoxBasePrice.Text = TextBoxBasePrice.Text.Remove(TextBoxBasePrice.Text.Length - 1);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// this method clear all the text boxes and all reset all the checkboxes and radio boxes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clearing All the data Filled!!");
            TextBoxBasePrice.Text ="0";
            textBox2.Text= "0";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            TextboxTrade.Text ="0";
            TextboxAmountdue.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            additional = 0;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                additional += stereo;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= stereo;
                textBox2.Text = Convert.ToString(additional);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                additional += leather;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= leather;
                textBox2.Text = Convert.ToString(additional);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                additional += computer;
                textBox2.Text = Convert.ToString(additional);
            }
            else
            {
                additional -= computer;
                textBox2.Text = Convert.ToString(additional);
            }
        }
        /// <summary>
        /// this method will change the font 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fontdialogbox = new FontDialog();
            fontdialogbox.ShowDialog();

            TextBoxBasePrice.Font = fontdialogbox.Font;
            TextboxAmountdue.Font = fontdialogbox.Font;
        }
        /// <summary>
        /// this method will change the text color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colordialogbox = new ColorDialog();
            colordialogbox.ShowDialog();

            TextBoxBasePrice.BackColor = colordialogbox.Color;
            TextboxAmountdue.BackColor = colordialogbox.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“This program calculates the amount due on a New or Used Vehicle");
            AboutBox aboutform = new AboutBox();
            aboutform.ShowDialog();
        }
        /// <summary>
        /// this method calculates the amount due 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(double.Parse(TextBoxBasePrice.Text) + double.Parse(textBox2.Text));
            textBox4.Text = Convert.ToString(double.Parse(textBox3.Text) * 0.13);
            textBox5.Text = Convert.ToString(double.Parse(textBox3.Text) + double.Parse(textBox4.Text));
            TextboxAmountdue.Text = Convert.ToString(double.Parse(textBox5.Text) - double.Parse(TextboxTrade.Text));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// this button calculates the amount due 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(double.Parse(TextBoxBasePrice.Text) + double.Parse(textBox2.Text));
            textBox4.Text = Convert.ToString(double.Parse(textBox3.Text) * 0.13);
            textBox5.Text = Convert.ToString(double.Parse(textBox3.Text) + double.Parse(textBox4.Text));
            TextboxAmountdue.Text = Convert.ToString(double.Parse(textBox5.Text) - double.Parse(TextboxTrade.Text));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextBoxBasePrice.Text = "0";
            textBox2.Text = "0";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            TextboxTrade.Text = "0";
            TextboxAmountdue.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = true;
            additional = 0;
        }
        private void SharpAutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult result = MessageBox.Show("Are You Sure?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        
    }}

   