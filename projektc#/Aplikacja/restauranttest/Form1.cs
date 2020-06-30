using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranttest
{
    /// <summary>
    /// Glowna klasa zawierajaca najwazniejsze metody oraz zmienne przechowujace dane
    /// </summary>
    public partial class Form1 : Form
    {
        const double Price_BottleWater = 1.5;
        const double Price_CheeseSandwich = 4.5;
        const double Price_ChocolateMilkShake = 7.0;
        const double Price_ChocolateMuffin = 6.8;
        const double Price_Coffee = 4.7;
        const double Price_Cola = 3.5;
        const double Price_FishSandwich = 14.3;
        const double Price_Fries = 7.5;
        const double Price_Hamburger = 15.0;
        const double Price_HashBrown = 3.9;
        const double Price_Orange = 5.50;
        const double Price_PancakesSyrup = 10.0;
        const double Price_PineappleStick = 2.0;
        const double Price_Salad = 5.5;
        const double Price_Strawberry = 7.0;
        const double Price_Tea = 2.0;
        const double Price_ToastedBagel = 6.5;
        const double Price_VanillaCone = 6.0;
        const double Price_VanillaShake = 6.0;
        const double Price_ChickenSalad = 11.0;
        const double Price_ChickenSandwich = 10.0;
        const double Price_OnionRings = 3.5;
        const double Tax_Rate = 3.9;

        public double iTax, iSubTotal, iTotal;
        public double cost, iChange;

        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        ///  Metoda dodaje mozliwosc wyboru metody platnosci
        /// </summary>
       private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" ");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card");

            EnableTextBoxes();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// metoda obslugujaca przycisk Total czyli obliczenie wartosci zamowienia
        /// </summary>
        
        internal void button1_Click(object sender, EventArgs e) // Przycisk Total
        {
            double[] itemcost = new double[22];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * Price_Fries; 
            itemcost[1] = Convert.ToDouble(textBox2.Text) * Price_Salad;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * Price_Hamburger;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * Price_OnionRings;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * Price_ChickenSalad;
            itemcost[5] = Convert.ToDouble(textBox6.Text) * Price_FishSandwich;
            itemcost[6] = Convert.ToDouble(textBox7.Text) * Price_CheeseSandwich;
            itemcost[7] = Convert.ToDouble(textBox8.Text) * Price_ChickenSandwich;
            itemcost[8] = Convert.ToDouble(textBox14.Text) * Price_HashBrown;
            itemcost[9] = Convert.ToDouble(textBox15.Text) * Price_ToastedBagel;
            itemcost[10] = Convert.ToDouble(textBox16.Text) * Price_PineappleStick;
            itemcost[11] = Convert.ToDouble(textBox17.Text) * Price_ChocolateMuffin;
            itemcost[12] = Convert.ToDouble(textBox18.Text) * Price_PancakesSyrup;
            itemcost[13] = Convert.ToDouble(textBox23.Text) * Price_Tea;
            itemcost[14] = Convert.ToDouble(textBox22.Text) * Price_Cola;
            itemcost[15] = Convert.ToDouble(textBox21.Text) * Price_Coffee;
            itemcost[16] = Convert.ToDouble(textBox20.Text) * Price_Orange;
            itemcost[17] = Convert.ToDouble(textBox19.Text) * Price_BottleWater;
            itemcost[18] = Convert.ToDouble(textBox27.Text) * Price_VanillaCone;
            itemcost[19] = Convert.ToDouble(textBox26.Text) * Price_VanillaShake;
            itemcost[20] = Convert.ToDouble(textBox25.Text) * Price_Strawberry;
            itemcost[21] = Convert.ToDouble(textBox24.Text) * Price_ChocolateMilkShake;

            
            string frytki = Convert.ToString(Price_Fries);

            if (comboBox1.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];

                textBox10.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox12.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox11.Text = Convert.ToString(iTotal);

                iChange = Convert.ToDouble(textBox13.Text); //reszta
                cost = iChange - iTotal;
                textBox9.Text = Convert.ToString(cost);

                textBox9.Text = String.Format("{0:C}", cost);
                textBox12.Text = String.Format("{0:C}", iTax);
                textBox10.Text = String.Format("{0:C}", iSubTotal);
                textBox11.Text = String.Format("{0:C}", iTotal);
            }

            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
               itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];

                textBox10.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox12.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox11.Text = Convert.ToString(iTotal);

                textBox12.Text = String.Format("{0:C}", iTax);
                textBox10.Text = String.Format("{0:C}", iSubTotal);
                textBox11.Text = String.Format("{0:C}", iTotal);
            }
        }
        /// <summary>
        /// Metoda obslugujaca przycisk Reset ktory resetuje wszystkie Boxy
        /// </summary>
      
        private void button2_Click(object sender, EventArgs e) //Przycisk Reset
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }
        /// <summary>
        /// Metoda obslugujaca przycisk Exit ktory konczy dzialanie programu
        /// </summary>

        private void button3_Click(object sender, EventArgs e)  //Przycisk Exit
        {
            DialogResult iExit;
            iExit = MessageBox.Show("You want to Exit?", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Metoda ktora resetuje TextBoxy
        /// </summary>
        private void ResetTextBoxes()
        {
             Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                 foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);   
            };
            func(Controls);
        }
        /// <summary>
        /// Metoda ktora uaktywnia TextBoxy
        /// </summary>
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        /// <summary>
        /// Metoda ktora resetuje CheckBoxy
        /// </summary>
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Fries
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Salad
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //Hamburger
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //OnionRings
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) //ChickenSalad
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) //FishSandwich
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) //CheeseSandwich
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) //ChickenSandwich
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e) //Hash Brown
        {
            if (checkBox9.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e) //Toasted Bagel
        {
            if (checkBox10.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();
            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e) //Pineapple Stick
        {
            if (checkBox12.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();
            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e) //Chocolate Muffin
        {
            if (checkBox13.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();
            }
            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e) //Pancakes - Syrup
        {
            if (checkBox11.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();
            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e) //Tea
        {
            if (checkBox14.Checked == true)
            {
                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();
            }
            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e) //Cola
        {
            if (checkBox16.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();
            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e) //Coffee
        {
            if (checkBox15.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();
            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e) //Orange
        {
            if (checkBox17.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();
            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e) //Bottle Water
        {
            if (checkBox18.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e) //Vanilla Cone
        {
            if (checkBox22.Checked == true)
            {
                textBox27.Enabled = true;
                textBox27.Text = "";
                textBox27.Focus();
            }
            else
            {
                textBox27.Enabled = false;
                textBox27.Text = "0";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e) //Vanilla Shake
        {
            if (checkBox21.Checked == true)
            {
                textBox26.Enabled = true;
                textBox26.Text = "";
                textBox26.Focus();
            }
            else
            {
                textBox26.Enabled = false;
                textBox26.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Metoda platnosci
        {
            if (comboBox1.Text == "Cash")
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e) //-----------------------------------------------------------------
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e) //Strawberry Shake
        {
            if (checkBox20.Checked == true)
            {
                textBox25.Enabled = true;
                textBox25.Text = "";
                textBox25.Focus();
            }
            else
            {
                textBox25.Enabled = false;
                textBox25.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e) //Chocolate Milk Shake
        {
            if (checkBox19.Checked == true)
            {
                textBox24.Enabled = true;
                textBox24.Text = "";
                textBox24.Focus();
            }
            else
            {
                textBox24.Enabled = false;
                textBox24.Text = "0";
            }
        }
    }
}
