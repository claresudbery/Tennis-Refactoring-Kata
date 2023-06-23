namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player1;
        private int player2;
        
        private string p1N;
        private string p2N;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1N = player1Name;
            this.p2N = player2Name;
        }

        public string GetScore()
        {
            string s;
            if ((player1 < 4 && player2 < 4) && (player1 + player2 < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[player1];
                return (player1 == player2) ? s + "-All" : s + "-" + p[player2];
            }
            else
            {
                if (player1 == player2)
                    return "Deuce";
                s = player1 > player2 ? p1N : p2N;
                return ((player1 - player2) * (player1 - player2) == 1) ? "Advantage " + s : "Win for " + s;
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

