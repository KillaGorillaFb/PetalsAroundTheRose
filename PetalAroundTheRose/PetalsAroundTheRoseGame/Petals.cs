using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundTheRoseGame
{
    //Developer:    Frankie Barrios
    //Date:         9/1/2018
    //Purpose:      Petals Around The Rose Game
    public partial class PetalsApp : Form
    {
        
        int roll = 0;
        int rollValue = 0;
        int bestRun = 0;
        int currentRun = 0;
        int correctGuess = 0;
        int incorrectGuess = 0;
        int totalRun = 0;
        int[] die = new int[5];
        Dice[] roseDice = new Dice[5];
        Random randNum = new Random();

        public PetalsApp()
        {
            InitializeComponent();
            btnAccept.Enabled = false;
        }// End of Method.

        /// <summary>
        /// Event Procedure: Event for Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PetalsApp_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < 5; index++)
            {
                roseDice[index] = new Dice { };
            }
            
        }// End of Event.

        /// <summary>
        /// Event Procedure: Simulate the rolling of dice and sets five
        ///  dice class objects to represent the dice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            // Generate a random number.
            // Sets properties of the dice class based on roll.
            // Note: Calls the GetPoints() Method to determine points.
            for (int index = 0; index < 5; index++)
            {
                roll = randNum.Next(1, 6);
                roseDice[index].DieFace = roll;
                roseDice[index].Points = GetPoints(roll);
            }

            // Determines the total value of the roll.
            // Calls the GetDieFace() method to set the picturebox objects to thier die image.
            for (int index = 0; index < 5; index++)
            {
                rollValue += roseDice[index].Points;
                GetDieFace(index);
            }

            btnAccept.Enabled = true;
            btnGo.Enabled = false;
            txtBxGuess.Text = "";
            txtBxGuess.Focus();
            lblMessage.Text = "";
        }// End of Event.

        /// <summary>
        /// Method: Determines the points that will be assigned based on the 
        ///  current roll.
        /// </summary>
        /// <param name="roll"></param>
        /// <returns></returns>
        public int GetPoints(int roll)
        {
            // Method level varibles.
            int value = 0;

            // If else for assigning point values.
            if (roll == 1 || roll == 2 || roll == 4 || roll == 6)
            {
                value = 0;
            }
            else if (roll == 3)
            {
                value = 2;
            }
            else if (roll == 5)
            {
                value = 4;
            }

            return value;
        }// End of Method.

        /// <summary>
        /// Method: Determines what die image to use based on the dieface property.
        /// </summary>
        /// <param name="index"></param>
        public void GetDieFace(int index)
        {
            switch (index)
            {
                case 0: picBxDie0.Image = imageList1.Images[(roseDice[index].DieFace) - 1];
                    break;
                case 1: picBxDie1.Image = imageList1.Images[(roseDice[index].DieFace) - 1];
                    break;
                case 2: picBxDie2.Image = imageList1.Images[(roseDice[index].DieFace) - 1];
                    break;
                case 3: picBxDie3.Image = imageList1.Images[(roseDice[index].DieFace) - 1];
                    break;
                default: picBxDie4.Image = imageList1.Images[(roseDice[index].DieFace) - 1];
                    break;
            }
        }// End of Method.

        /// <summary>
        /// Event Procedure: Checks the user entered number to determine if is
        ///  correct and adjust score accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Test input for correct answer.
            // Propt with error message if user input is invalid.
            if (txtBxGuess.Text != "")
            {
                if (Convert.ToInt32(txtBxGuess.Text) % 2 == 0) 
                {
                    // Determie if user answer is corret.
                    if (rollValue == Convert.ToInt32(txtBxGuess.Text))
                    {
                        correctGuess++;
                        currentRun++;
                        lblCorrecct.Text = correctGuess.ToString();
                        lblMessage.Text = "      CORRECT!";
                    }
                    else
                    {
                        incorrectGuess++;
                        currentRun = 0;
                        lblIncorrect.Text = incorrectGuess.ToString();
                        lblMessage.Text = "      INCORRECT!\r\n   Correct Answer was: " + rollValue;
                    }

                    // Determine best run.
                    if (bestRun < currentRun)
                    {
                        bestRun = currentRun;
                        lblBestRun.Text = currentRun.ToString();
                    }

                    // Reset buttons and text.
                    btnGo.Enabled = true;
                    btnAccept.Enabled = false;
                    rollValue = 0;
                }
                else
                {
                    MessageBox.Show("You must enter a even number or zero to place a guess.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must enter a even number or zero to place a guess.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblCurrentRun.Text = currentRun.ToString();
            totalRun++;
            lblTotalRolls.Text = totalRun.ToString();
        }// End of Event.

        /// <summary>
        /// Event Procedure: Test input to see if it is a number.
        /// Note: Allows only numerical input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxGuess_TextChanged(object sender, EventArgs e)
        {
            // Event level variables.
            int result = 0;

            // Test text for proper input.
            if (Int32.TryParse(txtBxGuess.Text, out result))
            {
               // Text fall through.
            }
            else
            {
                txtBxGuess.Text = "";
            }
        }// End of Event.

    }// End of Class.
}// End of Solution.
