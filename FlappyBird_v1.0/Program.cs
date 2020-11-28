using System;
using System.Windows.Forms;

namespace FlappyBird_v1._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //
        //Данные нужные для таблицы результатов игроков
        //
        static public GamersInformation Information = new GamersInformation("C:\\FlappyBird\\GamersNames.txt", "C:\\FlappyBird\\GamersScores.txt");
        static public int GamerScore = 0;
        static public int GamerPlace;
        static public string GamerName;
        static public ResultsTable ResultsTable;
        static public int NumberOfWinnersPlaces = 10;
        //
        //
        //
    }
}
