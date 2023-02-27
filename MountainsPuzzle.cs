using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MountainsPuzzle
{
    public partial class MountainsPuzzle : Form
    {
        private bool isTimerRunning;
        private DateTime startTime;
        private TimeSpan elapsedTime;
        Image originalimage = Image.FromFile(@"mountains4x4\mountains2.jpg");
        Image[,] puzzlePieces = new Image[4, 4];
        private PictureBox selectedPiece = null;
        private Point lastLocation;

        public MountainsPuzzle()
        {
            InitializeComponent();

            SplitImage(originalimage, puzzlePieces);
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
            ShufflePieces();

            if (!isTimerRunning)
            {

                GameTime.Start();
                isTimerRunning = true;

            }
            else
            {

                startTime = DateTime.Now;
                elapsedTime = TimeSpan.Zero;
                Timelbl.Text = "Game time: 00:00:00";

            }



        }



        private void MountainsPuzzle_Load(object sender, EventArgs e)
        {

            startTime = DateTime.Now;
            isTimerRunning = false;

        }

        private void SplitImage(Image originalImage, Image[,] puzzlePieces)
        {
            int pieceWidth = originalImage.Width / 4;
            int pieceHeight = originalImage.Height / 4;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Bitmap piece = new Bitmap(pieceWidth, pieceHeight);

                    using (Graphics g = Graphics.FromImage(piece))
                    {
                        g.DrawImage(originalImage, new Rectangle(0, 0, pieceWidth, pieceHeight), new Rectangle(x * pieceWidth, y * pieceHeight, pieceWidth, pieceHeight), GraphicsUnit.Pixel);
                    }

                    puzzlePieces[x, y] = piece;
                }
            }
        }

        public void ShufflePieces()
        {
            Random rand = new Random();

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    int newX = rand.Next(4);
                    int newY = rand.Next(4);

                    Image temp = puzzlePieces[x, y];
                    puzzlePieces[x, y] = puzzlePieces[newX, newY];
                    puzzlePieces[newX, newY] = temp;
                }
            }

            DisplayPieces();
        }

        private void DisplayPieces()
        {
            puzzlepan.Controls.Clear();

            int pieceWidth = puzzlepan.Width / 4;
            int pieceHeight = puzzlepan.Height / 4;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = puzzlePieces[x, y];
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Width = pieceWidth;
                    pb.Height = pieceHeight;
                    pb.Left = x * pieceWidth;
                    pb.Top = y * pieceHeight;

                    puzzlepan.Controls.Add(pb);
                    pb.MouseDown += pb_MouseDown;
                    pb.MouseMove += pb_MouseMove;
                    pb.MouseUp += pb_MouseUp;
                    pb.Tag = $"{x}{y}";
                }
            }
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            selectedPiece = null;
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {

            selectedPiece = (PictureBox)sender;
            lastLocation = e.Location;
            selectedPiece.BringToFront();
            // Check if the puzzle is solved
            if (IsPuzzleSolved())
            {
                GameTime.Stop();
                isTimerRunning = false;
                MessageBox.Show("Congratulations, you solved the puzzle!");
            }

        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedPiece != null)
            {
                int dx = e.X - lastLocation.X;
                int dy = e.Y - lastLocation.Y;
                selectedPiece.Left += dx;
                selectedPiece.Top += dy;
            }

        }


        private bool IsPuzzleSolved()
        {
            int[,] solvedState = new int[,]
            {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9, 10, 11 },
                { 12, 13, 14, 15 }
            };

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    int expectedIndex = solvedState[x, y];
                    int currentIndex = -1;

                    // Find the current index of the piece
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (puzzlePieces[i, j] != null && puzzlePieces[i, j].Tag != null && (int)puzzlePieces[i, j].Tag == expectedIndex)
                            {
                                currentIndex = i * 4 + j;
                                break;
                            }
                        }

                        if (currentIndex != -1)
                        {
                            break;
                        }
                    }

                    if (currentIndex != expectedIndex)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        private void GameTime_Tick(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                elapsedTime = DateTime.Now - startTime;
                Timelbl.Text = "Game time: " + elapsedTime.ToString(@"hh\:mm\:ss");
            }
            

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
