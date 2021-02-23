/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { }
                else if (scene == 1) { scene = 1; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 3) { scene = 0; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);
                    if (value <= 7) { scene = 7; }
                    else
                    {
                        scene = 2;
                    }

                }
                scene = 2;
            }
            else if (scene == 1) { scene = 4; }
            else if (scene == 2) { scene = 99; }
            else if (scene == 3) { scene = 99; }
            else if (scene == 4) { scene = 6; }
            else if (scene == 5) { scene = 99; }
            else if (scene == 6) { scene = 99; }
            else if (scene == 7) { scene = 99; }
        
    
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You are lost in a Forest";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 1:
                        sceneImage.BackgroundImage = Properties.Resources.forestLake;
                        SoundPlayer lakeSound = new SoundPlayer(Properties.Resources.brook);
                        lakeSound.Play();
                                  
                    outputLabel.Text = "You come to a lake, do you want to take a drink?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You fall into a pit and die, Play again?";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 3:
                    outputLabel.Text = "The water is stagnent, You die of Cholera, Play again?";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "A horse swims by, do you ride it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You tame the horse and ride to safety";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 6:
                    outputLabel.Text = "The horse walks by, you die of loneliness, Play again";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 7:
                    break;
                case 99:
                    outputLabel.Text = "Thanks for Playing";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    Refresh();

                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void RedLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
