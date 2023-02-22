using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainsPuzzle
{
    public partial class MountainsPuzzle : Form
    {
        private bool isTimerRunning;
        private DateTime startTime;
        private TimeSpan elapsedTime;
        public MountainsPuzzle()
        {
            InitializeComponent();
        }

        private void PauseGamebtn_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {

                GameTime.Stop();
                isTimerRunning = false;
                PauseGamebtn.Text = "UnPause";

            }
            else
            {

                GameTime.Start();
                isTimerRunning = true;
                startTime = DateTime.Now - elapsedTime;
                PauseGamebtn.Text = "Pause";

            }
            

        }

        private void Shufflebtn_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {

                GameTime.Start();
                isTimerRunning = true;

            }
            else
            {

                startTime = DateTime.Now;
                elapsedTime = TimeSpan.Zero;
                Timelbl.Text = "Game Time: 00:00:00";

            }
            


        }

        private void MountainsPuzzle_Load(object sender, EventArgs e)
        {

            startTime = DateTime.Now;
            isTimerRunning=false;

        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                elapsedTime = DateTime.Now - startTime;
                Timelbl.Text = "Game time: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
            

        }
    }
}
