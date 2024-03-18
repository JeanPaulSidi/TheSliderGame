using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSliderGame
{
    public partial class Form1 : Form
    {

        int NumberofMoves;
        Button[] ButtonArray = new Button[16];

        public void CreateButtonArray() 
        {
            ButtonArray[0] = button1;
            ButtonArray[1] = button2;
            ButtonArray[2] = button3;
            ButtonArray[3] = button4;
            ButtonArray[4] = button5;
            ButtonArray[5] = button6;
            ButtonArray[6] = button7;
            ButtonArray[7] = button8;
            ButtonArray[8] = button9;
            ButtonArray[9] = button10;
            ButtonArray[10] = button11;
            ButtonArray[11] = button12;
            ButtonArray[12] = button13;
            ButtonArray[13] = button14;
            ButtonArray[14] = button15;
            ButtonArray[15] = button16;

        }

        public void HideEmptyButton() 
        {
            for (int i = 0; i < ButtonArray.Length; i++) 
            {
                if (ButtonArray[i].Text == "") 
                {
                    ButtonArray[i].Visible = false;
                }
                else 
                {
                    ButtonArray[i].Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void CheckWinningGame() 
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && 
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && 
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "") 
            {
                MessageBox.Show("Awesome, you've won !", "Slider!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

        }

        public void TrySwapping(Button BtnClicked, Button Btn) 
        {
            if (Btn.Text == "") 
            {
                Btn.Text = BtnClicked.Text;
                BtnClicked.Text = "";  
            }

            HideEmptyButton();

        }

        public void ShuffleTheSquares() 
        {
            int[] Tab;
            Tab = new int[15];

            int i;
            int j;
            int RandomNumber;
            bool AlreadyPicked;

            Random Rand;
            Rand = new Random();
           
            i = 0;

            do 
            {
                
                RandomNumber = Rand.Next(1,16);
                AlreadyPicked = false;

                for (j = 0; j <= i; j++) 
                {
                    if (Tab[j] == RandomNumber) 
                    {
                        AlreadyPicked = true;
                        break;
                    }
                }
              
                if(!AlreadyPicked)
                {
                    Tab[i] = RandomNumber;
                    i++;
                }

            }while (i < 15);

            button1.Text = Convert.ToString(Tab[0]);
            button2.Text = Convert.ToString(Tab[1]);
            button3.Text = Convert.ToString(Tab[2]);
            button4.Text = Convert.ToString(Tab[3]);
            button5.Text = Convert.ToString(Tab[4]);
            button6.Text = Convert.ToString(Tab[5]);
            button7.Text = Convert.ToString(Tab[6]);
            button8.Text = Convert.ToString(Tab[7]);
            button9.Text = Convert.ToString(Tab[8]);
            button10.Text = Convert.ToString(Tab[9]);
            button11.Text = Convert.ToString(Tab[10]);
            button12.Text = Convert.ToString(Tab[11]);
            button13.Text = Convert.ToString(Tab[12]);
            button14.Text = Convert.ToString(Tab[13]);
            button15.Text = Convert.ToString(Tab[14]);
            button16.Text = "";
            

        }

        private void Quit_Click(object sender, EventArgs e)
        {

            DialogResult GameExit;
            GameExit = MessageBox.Show("Are you sure you want to exit Slider Game ?", 
                              "Slider!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (GameExit == DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void NewWinGame_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = "";
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(9);
            button14.Text = Convert.ToString(13);
            button15.Text = Convert.ToString(14);
            button16.Text = Convert.ToString(15);

            HideEmptyButton();

            NumberofMoves = 0;
            label1.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrySwapping(button1, button2);
            TrySwapping(button1, button5);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrySwapping(button2, button1);
            TrySwapping(button2, button3);
            TrySwapping(button2, button6);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrySwapping(button3, button2);
            TrySwapping(button3, button4);
            TrySwapping(button3, button7);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrySwapping(button4, button3);
            TrySwapping(button4, button8);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrySwapping(button5, button1);
            TrySwapping(button5, button6);
            TrySwapping(button5, button9);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrySwapping(button6, button2);
            TrySwapping(button6, button5);
            TrySwapping(button6, button7);
            TrySwapping(button6, button10);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TrySwapping(button7, button3);
            TrySwapping(button7, button6);
            TrySwapping(button7, button8);
            TrySwapping(button7, button11);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TrySwapping(button8, button4);
            TrySwapping(button8, button7);
            TrySwapping(button8, button12);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            TrySwapping(button9, button5);
            TrySwapping(button9, button10);
            TrySwapping(button9, button13);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TrySwapping(button10, button6);
            TrySwapping(button10, button9);
            TrySwapping(button10, button11);
            TrySwapping(button10, button14);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            TrySwapping(button11, button7);
            TrySwapping(button11, button10);
            TrySwapping(button11, button12);
            TrySwapping(button11, button15);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            TrySwapping(button12, button8);
            TrySwapping(button12, button11);
            TrySwapping(button12, button16);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            TrySwapping(button13, button9);
            TrySwapping(button13, button14);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            TrySwapping(button14, button10);
            TrySwapping(button14, button13);
            TrySwapping(button14, button15);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            TrySwapping(button15, button11);
            TrySwapping(button15, button14);
            TrySwapping(button15, button16);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            TrySwapping(button16, button12);
            TrySwapping(button16, button15);

            NumberofMoves++;
            label1.Text = ("Slider!  - Move " + NumberofMoves);

            CheckWinningGame();

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ShuffleTheSquares();

            HideEmptyButton();

            NumberofMoves = 0;
            label1.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtonArray();

            ShuffleTheSquares();

            HideEmptyButton();

            NumberofMoves = 0;
            
        }
    }
}
