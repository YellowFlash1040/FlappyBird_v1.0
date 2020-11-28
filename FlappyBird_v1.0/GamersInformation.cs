using System;
using System.IO;

namespace FlappyBird_v1._0
{
    public class GamersInformation
    {
        public string GamersNamesFilePath { get; set; }
        public string GamersScoresFilePath { get; set; }
        public GamersInformation(string gamersNamesFilePath, string gamersScoresFilePath)
        {
            GamersNamesFilePath = gamersNamesFilePath;
            GamersScoresFilePath = gamersScoresFilePath;

            FillTheFiles();
        }

        private void FillTheFiles()
        {
            StreamReader sr = new StreamReader(this.GamersNamesFilePath);
            string s = sr.ReadLine();
            if (s == null || s == "")
            {
                sr.Close();

                StreamWriter swNames = new StreamWriter(this.GamersNamesFilePath);
                StreamWriter swScores = new StreamWriter(this.GamersScoresFilePath);
                for (int i = 0; i < 10; i++)
                {
                    swScores.WriteLine("0");
                    swNames.WriteLine("Пусто");
                }
                swScores.Close();
                swNames.Close();
            }
        }

        public void SaveNewGameInformation()
        {
            StreamWriter swScores = new StreamWriter(this.GamersScoresFilePath);
            StreamWriter swNames = new StreamWriter(this.GamersNamesFilePath);
            for (int i = 0; i < Program.NumberOfWinnersPlaces; i++)
            {
                swScores.WriteLine(Program.ResultsTable.PlacesScores[i]);
                swNames.WriteLine(Program.ResultsTable.PlacesNames[i]);
            }
            swScores.Close();
            swNames.Close();
        }

        public int[] ReadGamersResults()
        {
            int[] Scores = new int[Program.NumberOfWinnersPlaces];
            StreamReader srScores = new StreamReader(this.GamersScoresFilePath);
            for (int i = 0; i < Scores.Length; i++)
            {
                Scores[i] = Convert.ToInt32(srScores.ReadLine());
            }
            srScores.Close();

            return Scores;
        }
        public string[] ReadGamerNames()
        {
            string[] Names = new string[Program.NumberOfWinnersPlaces];
            StreamReader srNames = new StreamReader(this.GamersNamesFilePath);
            for (int i = 0; i < Names.Length; i++)
            {
                Names[i] = srNames.ReadLine();
            }
            srNames.Close();

            return Names;
        }
        //я думал заменить эти два метода, потомучто мне не нравиться что дважды проходиться один и тот же цикл
        // проблема заключалась в том что один метод возвращает только один массив, а мне нужно два массива
        // тогда я подумал заменить эти два метода на один и чтоб он возвращал массив из двух массивов, а потом "расспаковывался" на два отдельных массива
        // но я не щнаю что хуже это ↑ или два раза пройти цикл, поэтому покачто оставил так
    }
}
