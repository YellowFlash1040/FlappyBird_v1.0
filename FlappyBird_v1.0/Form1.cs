using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird_v1._0
{
    public partial class Form1 : Form
    {
        Bird flappy;
        Wall[] walls;
        List<PictureBox> pbWalls;

        Vector directionOfWallsMove = new Vector(Wall.SpeedOFWallMove, 0);
        int NumberOfWalls = 10;
        int spaceBetweenBarriers;
        int LeftPositionOfFirstAndSecondWallsAtStartOfTheGame = 1200;

        int NumberOfBlocksInUpWall;
        int NumberOfBlocksInDownWall;
        //int NumberBlocksInOneBarrier = 7;
        int NumberBlocksInOneBarrier;

        int SpeedOfGroundMove = Wall.SpeedOFWallMove;

        bool[] PointsByBarriers;

        Random rnd;

        int NumberOfGameMode;
        int GameModePlusScore;

        int[] RandomGameModePlusScore = new int[3] { 10, 50, 100 };

        public Form1()
        {
            InitializeComponent();
            spaceBetweenBarriers = 400;
            PlaceGameObjectsOnStartingLocations();
            KeyPreview = true;

            rnd = new Random();
        }


        private void timer_Wall_And_Ground_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < walls.Length; i++)
            {
                if (pbWalls[i].Left < -pbWalls[i].Width)
                {
                    ChangeSizeOfBarrier(i);
                    ChangeLocationOfBarrier(i);
                }
                else
                {
                    MoveBarrier(i);
                }

                if (i % 2 == 0)
                {
                    if (flappy.R.X > walls[i].R.X + walls[i].Width && PointsByBarriers[i / 2]) 
                    {
                        Program.GamerScore += GameModePlusScore;
                        GameScore_Label.Text = Program.GamerScore.ToString();
                        PointsByBarriers[i/2] = false;
                    }
                }
            }

            if (pbGround_FirstHalf.Left < -pbGround_FirstHalf.Width)
            {
                pbGround_FirstHalf.BringToFront();
                pbGround_FirstHalf.Left = pbGround_SecondHalf.Left + pbGround_SecondHalf.Width - 14;
            }
            else
            {
                pbGround_FirstHalf.Left += SpeedOfGroundMove;
            }

            if (pbGround_SecondHalf.Left < -pbGround_SecondHalf.Width)
            {
                pbGround_SecondHalf.Left = pbGround_FirstHalf.Left + pbGround_FirstHalf.Width - 3;
                pbGround_SecondHalf.BringToFront();
            }
            else
            {
                pbGround_SecondHalf.Left += SpeedOfGroundMove;
            }
        }


        private void MoveBarrier(int i)
        {
            walls[i].Move(directionOfWallsMove);
            pbWalls[i].Location = new Point((int)walls[i].R.X, (int)walls[i].R.Y);
        }


        private void ChangeLocationOfBarrier(int i)
        {
            if (i == 0)
            {
                walls[i].R.X = pbWalls[pbWalls.Count - 2].Left + spaceBetweenBarriers;
            }
            else if (i == 1)
            {
                walls[i].R.X = pbWalls[pbWalls.Count - 1].Left + spaceBetweenBarriers;
            }
            else
            {
                walls[i].R.X = pbWalls[i - 2].Left + spaceBetweenBarriers;
            }

            pbWalls[i].Left = (int)walls[i].R.X;

            if (i % 2 == 0)
            {
                PointsByBarriers[i / 2] = true;
            }
        }


        private void ChangeSizeOfBarrier(int i)
        {
            /////////////////////////////////////////////////////////////
            if(NumberOfGameMode == 4)
            {
                NumberBlocksInOneBarrier = rnd.Next(4, 7);
            }
            /////////////////////////////////////////////////////////////
            
            if (i % 2 == 0)
            {
                if (NumberOfGameMode == 1 || NumberOfGameMode == 2 || NumberOfGameMode == 4)
                {
                    if (NumberOfBlocksInDownWall == 1)
                    {
                        NumberOfBlocksInUpWall = rnd.Next(2, NumberBlocksInOneBarrier - 1);
                        pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                    }
                    else
                    {
                        NumberOfBlocksInUpWall = rnd.Next(1, NumberBlocksInOneBarrier - 1);
                        pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                    }
                }
                else
                {
                    if (NumberOfBlocksInDownWall == 1)
                    {
                        NumberOfBlocksInUpWall = rnd.Next(3, NumberBlocksInOneBarrier - 1);
                        pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                    }
                    else
                    {
                        NumberOfBlocksInUpWall = rnd.Next(2, NumberBlocksInOneBarrier - 1);
                        pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                    }
                }
            }
            else if (i % 2 == 1)
            {
                NumberOfBlocksInDownWall = NumberBlocksInOneBarrier - NumberOfBlocksInUpWall;
                pbWalls[i].Height = NumberOfBlocksInDownWall * 71;
                walls[i].R.Y = (this.ClientSize.Height - pbGround_FirstHalf.Height) - pbWalls[i].Height;
            }
        }


        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Visible = false;
            info_button.Visible = false;
            GamersResults_button.Visible = false;

            EasyGameMode_button.Visible = true;
            MediumGameMode_button.Visible = true;
            HardGameMode_button.Visible = true;
            RandomGameMode_button.Visible = true;
        }


        private void StartGame()
        {
            EasyGameMode_button.Visible = false;
            MediumGameMode_button.Visible = false;
            HardGameMode_button.Visible = false;
            RandomGameMode_button.Visible = false;

            if (NumberOfGameMode == 1)
            {
                NumberBlocksInOneBarrier = 5;
            }
            else if (NumberOfGameMode == 2)
            {
                NumberBlocksInOneBarrier = 7;
            }
            else if (NumberOfGameMode == 3)
            {
                NumberBlocksInOneBarrier = 8;
            }
            else
            {
                ///////////////////
                NumberBlocksInOneBarrier = rnd.Next(4, 7);
                //////////////////
            }

            GameScore_Label.Visible = true;

            InitializeAllAraysAndLists();
            CreateWalls();
            if (NumberOfGameMode == 3)
            {
                for (int i = 0; i < pbWalls.Count; i++)
                {
                    pbWalls[i].Width = pbWalls[i].Width * 2 / 3;
                }
            }

            for (int i = 0; i < NumberOfWalls; i++)
            {
                pbWalls[i].Visible = true;

                if (i % 2 == 1)
                {
                    walls[i].R.Y = pbGround_FirstHalf.Top - pbWalls[i].Height;
                }
            }

            CreateBird();

            flappy.r0 = new Vector(pbBird.Left, pbBird.Top);
            flappy.v = new Vector(0, 0);

            timer1.Start();
            timer4.Start();
        }


        private void CreateBird()
        {
            pbBird.Visible = true;
            flappy = new Bird(pbBird.Width, pbBird.Height, pbBird.Location);
        }

        
        private void CreateWalls()
        {
            pbWalls.Add(pbWall1);
            pbWalls.Add(pbWall2);
            pbWalls.Add(pbWall3);
            pbWalls.Add(pbWall4);
            pbWalls.Add(pbWall5);
            pbWalls.Add(pbWall6);
            pbWalls.Add(pbWall7);
            pbWalls.Add(pbWall8);
            pbWalls.Add(pbWall9);
            pbWalls.Add(pbWall10);

            for (int i = 0; i < NumberOfWalls; i++)
            {
                walls[i] = new Wall(86, 138, new Vector(pbWalls[i].Left, pbWalls[i].Top));
                if (i % 2 == 0)
                {
                    if (NumberOfGameMode == 1 || NumberOfGameMode == 2 || NumberOfGameMode == 4)
                    {
                        if (NumberOfBlocksInDownWall == 1)
                        {
                            NumberOfBlocksInUpWall = rnd.Next(2, NumberBlocksInOneBarrier - 1);
                            pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                        }
                        else
                        {
                            NumberOfBlocksInUpWall = rnd.Next(1, NumberBlocksInOneBarrier - 1);
                            pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                        }
                    }
                    else
                    {
                        if (NumberOfBlocksInDownWall == 1)
                        {
                            NumberOfBlocksInUpWall = rnd.Next(3, NumberBlocksInOneBarrier - 1);
                            pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                        }
                        else
                        {
                            NumberOfBlocksInUpWall = rnd.Next(2, NumberBlocksInOneBarrier - 1);
                            pbWalls[i].Height = NumberOfBlocksInUpWall * 71;
                        }
                    }
                }
                else
                {
                    NumberOfBlocksInDownWall = NumberBlocksInOneBarrier - NumberOfBlocksInUpWall;
                    pbWalls[i].Height = NumberOfBlocksInDownWall * 71;
                    walls[i].R.Y = this.ClientSize.Height - pbWalls[i].Height;
                }
            }
        }


        private void InitializeAllAraysAndLists()
        {
            walls = new Wall[NumberOfWalls];
            pbWalls = new List<PictureBox>();

            PointsByBarriers = new bool[] { true, true, true, true, true };
        }
        

        private void PlaceGameObjectsOnStartingLocations()
        {
            pbWall1.Left = LeftPositionOfFirstAndSecondWallsAtStartOfTheGame;
            pbWall3.Left = pbWall1.Left + spaceBetweenBarriers;
            pbWall5.Left = pbWall3.Left + spaceBetweenBarriers;
            pbWall7.Left = pbWall5.Left + spaceBetweenBarriers;
            pbWall9.Left = pbWall7.Left + spaceBetweenBarriers;

            pbWall2.Left = LeftPositionOfFirstAndSecondWallsAtStartOfTheGame;
            pbWall4.Left = pbWall2.Left + spaceBetweenBarriers;
            pbWall6.Left = pbWall4.Left + spaceBetweenBarriers;
            pbWall8.Left = pbWall6.Left + spaceBetweenBarriers;
            pbWall10.Left = pbWall8.Left + spaceBetweenBarriers;
        }


        private void timer_Bird_Tick(object sender, EventArgs e)
        {
            pbBird.Location = flappy.Move();

            if (flappy.R.Y + flappy.Height >= pbGround_FirstHalf.Top)
            {
                GameOver();
            }
            else
            {

                for (int i = 0; i < walls.Length; i++)
                {
                    if (flappy.IsCollision(pbWalls[i]))
                    {
                        GameOver();
                        break;
                    }
                }
            }

            flappy.t += timer2.Interval/1000.0;
        }


        private void PauseGame()
        {
            timer1.Stop();
            timer2.Stop();
        }


        private void ContinueGame()
        {
            timer1.Start();
            timer2.Start();
        }


        private void GameOver()
        {
            timer2.Stop();
            timer1.Stop();

            GameOver_Label.Visible = true;
            GameOver_Label.BringToFront();
            Restart_button.Visible = true;
            Restart_button.BringToFront();
            exit_button.Visible = true;
            exit_button.BringToFront();

            ////////////////////////////////////////////////////////////
            GamersResults_button.Left += 7;
            GamersResults_button.Top += 35;
            GamersResults_button.Visible = true;
            GamersResults_button.BringToFront();
            ////////////////////////////////////////////////////////////

            Program.ResultsTable = new ResultsTable(Program.Information.ReadGamersResults(), Program.Information.ReadGamerNames());

            if (Program.GamerScore == 0)
            {
                for (int i = 0; i < Program.NumberOfWinnersPlaces; i++)
                {
                    if (Program.ResultsTable.PlacesNames[i] == "Пусто")
                    {
                        Program.GamerPlace = i;

                        //if number == 1 this ↓ will create Form "AskGamerNameForm", and if number == 2 this ↓ will create Form "gamersResultsTableForm", for more information read class CreateNewForm 
                        CreateNewForm nameForm = new CreateNewForm(1);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Program.ResultsTable.PlacesScores.Length; i++)
                {
                    if (Program.GamerScore > Program.ResultsTable.PlacesScores[i])
                    {
                        Program.GamerPlace = i;

                        //if number == 1 this ↓ will create Form "AskGamerNameForm", and if number == 2 this ↓ will create Form "gamersResultsTableForm", for more information read class CreateNewForm 
                        CreateNewForm nameForm = new CreateNewForm(1);
                        break;
                    }
                    else if (Program.GamerScore == Program.ResultsTable.PlacesScores[i])
                    {
                        if (i < Program.ResultsTable.PlacesScores.Length - 1)
                        {
                            Program.GamerPlace = i + 1;

                            //if number == 1 this ↓ will create Form "AskGamerNameForm", and if number == 2 this ↓ will create Form "gamersResultsTableForm", for more information read class CreateNewForm 
                            CreateNewForm nameForm = new CreateNewForm(1);
                            break;
                        }
                    }
                }
            }
        }

       
        private void Restart_button_Click(object sender, EventArgs e)
        {
            GameOver_Label.Visible = false;
            Restart_button.Visible = false;

            RestartGame();

            timer1.Start();
            timer4.Start();
        }


        private void RestartGame()
        {
            this.Controls.Clear();
            InitializeComponent();
            PlaceGameObjectsOnStartingLocations();
            KeyPreview = true;
            textBox1.Select();

            Program.GamerScore = 0;

            startGameButton.Visible = false;
            info_button.Visible = false;
            GamersResults_button.Visible = false;

            if(NumberOfGameMode == 4)
            {
                GameModePlusScore = RandomGameModePlusScore[rnd.Next(0, 3)];
            }

            StartGame();
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            timer2.Start();
        }

        
        private void pbGround_FirstHalf_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flappy.ChangeDirectionOfMove();
            }
            else if(e.Button == MouseButtons.Right)
            {
                CallGameMenu();
            }
        }


        private void pbGround_SecondHalf_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flappy.ChangeDirectionOfMove();
            }
            else if (e.Button == MouseButtons.Right)
            {
                CallGameMenu();
            }
        }


        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                flappy.ChangeDirectionOfMove();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                CallGameMenu();
            }
        }


        private void CallGameMenu()
        {
            PauseGame();
            timer4.Stop();

            Esc_menu_background.Visible = true;
            Esc_menu_background.BringToFront();
            Restart_button.Visible = true;
            Restart_button.BringToFront();
            Esc_continue_button.Visible = true;
            Esc_continue_button.BringToFront();
            exit_button.Visible = true;
            exit_button.BringToFront();
        }


        private void info_button_Click(object sender, EventArgs e)
        {
            startGameButton.Visible = false;
            info_button.Visible = false;
            GamersResults_button.Visible = false;

            info_GameControl_label.Visible = true;
            info_GameRules_label.Visible = true;
            info_GameInstructions_label.Visible = true;
            info_GoodLuck_label.Visible = true;
            back_info_button.Visible = true;
        }


        private void Esc_continue_button_Click(object sender, EventArgs e)
        {
            ContinueGame();

            Esc_menu_background.Visible = false ;
            Restart_button.Visible = false;
            Esc_continue_button.Visible = false;
            exit_button.Visible = false;

            textBox1.Select();
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            PauseGame();
            Program.GamerScore = 0;
            this.Controls.Clear();

            InitializeComponent();
            PlaceGameObjectsOnStartingLocations();
            KeyPreview = true;
        }


        private void back_info_button_Click(object sender, EventArgs e)
        {
            info_GameControl_label.Visible = false;
            info_GameRules_label.Visible = false;
            info_GameInstructions_label.Visible = false;
            back_info_button.Visible = false;
            info_GoodLuck_label.Visible = false;

            startGameButton.Visible = true;
            info_button.Visible = true;
            GamersResults_button.Visible = true;
        }

        private void GamersResults_button_Click(object sender, EventArgs e)
        {
            Program.ResultsTable = new ResultsTable(Program.Information.ReadGamersResults(), Program.Information.ReadGamerNames());
            CreateNewForm newForm = new CreateNewForm(2);
        }

        private void EasyGameMode_button_Click(object sender, EventArgs e)
        {
            NumberOfGameMode = 1;
            GameModePlusScore = 10;
            spaceBetweenBarriers = 400;
            StartGame();
        }

        private void MediumGameMode_button_Click(object sender, EventArgs e)
        {
            NumberOfGameMode = 2;
            GameModePlusScore = 50;
            spaceBetweenBarriers = 400;
            StartGame();
        }

        private void HardGameMode_button_Click(object sender, EventArgs e)
        {
            NumberOfGameMode = 3;
            GameModePlusScore = 100;
            spaceBetweenBarriers = 540;
            PlaceGameObjectsOnStartingLocations();
            StartGame();
        }

        private void RandomGameMode_button_Click(object sender, EventArgs e)
        {
            NumberOfGameMode = 4;
            GameModePlusScore = RandomGameModePlusScore[rnd.Next(0, 2)];
            spaceBetweenBarriers = 400;
            StartGame();
        }
    }
}
