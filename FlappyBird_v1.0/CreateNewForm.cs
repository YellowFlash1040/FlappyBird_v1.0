using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird_v1._0
{
    class CreateNewForm
    {
        public Form NewForm;

        // this ↓ need to create Form "AskGamerNameForm"
        Label labelEnterYourName;
        Button SaveName_button;
        TextBox EnterYourName_textBox;

        // this ↓ need t6 create Form "gamersResultsTableForm"
        Label[] GamerNamePlaceInResultsTable;
        Label[] GamerScorePlaceInResultsTable;

        public CreateNewForm(int Number)
        {
            if (Number == 1) //this ↓ create Form "AskGamerNameForm" 
            {
                NewForm = new Form();
                NewForm.Name = "AskGamerNameForm";
                NewForm.Size = new Size(300, 200);
                NewForm.StartPosition = FormStartPosition.CenterScreen;
                NewForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                NewForm.Text = "GoodJob!";
                NewForm.Icon = Properties.Resources.GameIcon;

                SaveName_button = new Button();
                SaveName_button.Text = "Save";
                SaveName_button.Location = new Point(NewForm.ClientSize.Width / 2 - SaveName_button.Width / 2, 100);
                SaveName_button.Click += new EventHandler(this.SaveName_button_Click);
                SaveName_button.Enabled = false;
                NewForm.Controls.Add(SaveName_button);

                labelEnterYourName = new Label();
                labelEnterYourName.Text = "Enter your name";
                labelEnterYourName.AutoSize = true;
                labelEnterYourName.Location = new Point(SaveName_button.Left + SaveName_button.Width / 2 - labelEnterYourName.Width / 2, 20);
                NewForm.Controls.Add(labelEnterYourName);

                EnterYourName_textBox = new TextBox();
                EnterYourName_textBox.Location = new Point(SaveName_button.Left + SaveName_button.Width / 2 - EnterYourName_textBox.Width / 2, 50);
                EnterYourName_textBox.TextChanged += new EventHandler(this.EnterYourName_textBox_TextChanged);
                NewForm.Controls.Add(EnterYourName_textBox);

                NewForm.Show();
                EnterYourName_textBox.Select();
            }
            else //this ↓ create Form "gamersResultsTableForm"
            {
                GamerNamePlaceInResultsTable = new Label[Program.NumberOfWinnersPlaces];
                GamerScorePlaceInResultsTable = new Label[Program.NumberOfWinnersPlaces];

                NewForm = new Form();
                NewForm.Name = "gamersResultsTableForm";
                NewForm.StartPosition = FormStartPosition.CenterScreen;
                NewForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                NewForm.Text = "Results";
                NewForm.Icon = Properties.Resources.GameIcon;

                Label LabelFirstPlaceWinnersName = new Label();
                LabelFirstPlaceWinnersName.Text = Program.ResultsTable.PlacesNames[0];
                LabelFirstPlaceWinnersName.AutoSize = true;
                LabelFirstPlaceWinnersName.Location = new Point(NewForm.ClientSize.Width / 2 - LabelFirstPlaceWinnersName.Width + 30, 20);
                GamerNamePlaceInResultsTable[0] = LabelFirstPlaceWinnersName;
                NewForm.Controls.Add(LabelFirstPlaceWinnersName);

                Label LabelFirstPlaceWinnersScore = new Label();
                LabelFirstPlaceWinnersScore.Text = Program.ResultsTable.PlacesScores[0].ToString();
                LabelFirstPlaceWinnersScore.AutoSize = true;
                LabelFirstPlaceWinnersScore.Location = new Point(LabelFirstPlaceWinnersName.Left + 100, 20);
                GamerScorePlaceInResultsTable[0] = LabelFirstPlaceWinnersScore;
                NewForm.Controls.Add(LabelFirstPlaceWinnersScore);

                for (int i = 1; i < Program.NumberOfWinnersPlaces; i++)
                {
                    Label LabelWinnersName = new Label();
                    LabelWinnersName.Text = Program.ResultsTable.PlacesNames[i];
                    LabelWinnersName.AutoSize = true;
                    LabelWinnersName.Location = new Point(LabelFirstPlaceWinnersName.Left, GamerNamePlaceInResultsTable[i - 1].Top + GamerNamePlaceInResultsTable[i - 1].Height + 10);
                    GamerNamePlaceInResultsTable[i] = LabelWinnersName;
                    NewForm.Controls.Add(LabelWinnersName);

                    Label LabelWinnersScore = new Label();
                    LabelWinnersScore.Text = Program.ResultsTable.PlacesScores[i].ToString();
                    LabelWinnersScore.AutoSize = true;
                    LabelWinnersScore.Location = new Point(LabelFirstPlaceWinnersName.Left + 100, GamerScorePlaceInResultsTable[i - 1].Top + GamerScorePlaceInResultsTable[i - 1].Height + 10);
                    GamerScorePlaceInResultsTable[i] = LabelWinnersScore;
                    NewForm.Controls.Add(LabelWinnersScore);
                }

                NewForm.Size = new Size(300, GamerNamePlaceInResultsTable[GamerNamePlaceInResultsTable.Length - 1].Top + LabelFirstPlaceWinnersName.Height + 70);

                NewForm.Show();
            }
        }

        public void SaveName_button_Click(object sender, EventArgs e)
        {
            Program.GamerName = EnterYourName_textBox.Text;
            Program.ResultsTable.ReplaceWinners();
            Program.Information.SaveNewGameInformation();
            NewForm.Dispose();
        }

        private void EnterYourName_textBox_TextChanged(object sender, EventArgs e)
        {
            if (EnterYourName_textBox.Text != "")
            {
                SaveName_button.Enabled = true;
            }
            else if(EnterYourName_textBox.Text == "")
            {
                SaveName_button.Enabled = false;
            }
        }
    }
}
