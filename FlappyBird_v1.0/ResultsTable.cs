namespace FlappyBird_v1._0
{
    public class ResultsTable
    {
        public int[] PlacesScores { get; set; }
        public string[] PlacesNames { get; set; }
        public ResultsTable(int[] Scores, string[] Names)
        {
            PlacesScores = Scores;
            PlacesNames = Names;
        }


        public void ReplaceWinners()
        {
            for (int i = Program.NumberOfWinnersPlaces - 1; i > Program.GamerPlace; i--)
            {
                Program.ResultsTable.PlacesNames[i] = Program.ResultsTable.PlacesNames[i - 1];
                Program.ResultsTable.PlacesScores[i] = Program.ResultsTable.PlacesScores[i - 1];
            }

            Program.ResultsTable.PlacesNames[Program.GamerPlace] = Program.GamerName;
            Program.ResultsTable.PlacesScores[Program.GamerPlace] = Program.GamerScore;
        }


        public void ReplaceWinners(int GamerPlace, string GamerName, int GamerScore, ResultsTable resultsTable)
        {
            if (GamerPlace <= resultsTable.PlacesScores.Length)
            {
                int previousScore = resultsTable.PlacesScores[GamerPlace];
                resultsTable.PlacesScores[GamerPlace] = GamerScore;
                resultsTable.PlacesScores[GamerPlace + 1] = previousScore;

                string previousName = resultsTable.PlacesNames[GamerPlace];
                resultsTable.PlacesNames[GamerPlace] = GamerName;
                resultsTable.PlacesNames[GamerPlace + 1] = previousName;
            }
            else
            {
                resultsTable.PlacesScores[GamerPlace] = GamerScore;

                resultsTable.PlacesNames[GamerPlace] = GamerName;
            }
        }
    }
}
