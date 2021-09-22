using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRollDieImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRollDie_Click(object sender, EventArgs e)
        {
            //Declarations
            int die1, die2, total;
            Random randomizer = new Random();

            //get random numbers
            die1 = randomizer.Next(0, 6);
            die2 = randomizer.Next(1, 7);

            //Display the dice
            PicDie1.Image = imageList1.Images[die1];
       




            switch (die2)
            {
                case 1:
                    PicDie2.Image = imageList1.Images["dice1.jpg"];
                    break;
                case 2:
                    PicDie2.Image = imageList1.Images["dice2.jpg"];
                    break;
                case 3:
                    PicDie2.Image = imageList1.Images["dice3.jpg"];
                    break;
                case 4:
                    PicDie2.Image = imageList1.Images["dice4.jpg"];
                    break;
                case 5:
                    PicDie2.Image = imageList1.Images["dice5.jpg"];
                    break;
                case 6:
                    PicDie2.Image = imageList1.Images["dice6.jpg"];
                    break;
            }


            //calculate the total and display in label
            total = die1 + 1 + die2;

            LblTotal.Text = total.ToString();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
