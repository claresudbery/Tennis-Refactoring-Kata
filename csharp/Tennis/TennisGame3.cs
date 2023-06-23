namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player1;
        private int player2;
        
        private readonly string player1Name;
        private readonly string player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            if ((player1 < 4 && player2 < 4) && (player1 + player2 < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                var score = p[player1];
                return (player1 == player2) ? score + "-All" : score + "-" + p[player2];
            }
            else
            {
                if (player1 == player2)
                    return "Deuce";
                var score = player1 > player2 ? player1Name : player2Name;
                return ((player1 - player2) * (player1 - player2) == 1) ? "Advantage " + score : "Win for " + score;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.player1 += 1;
            else
                this.player2 += 1;
        }

    }
}

