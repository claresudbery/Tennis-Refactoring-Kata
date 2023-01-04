namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private string player1Name;
        private string player2Name;
        private int player1point;
        private int player2point;

        private string player1result = "";
        private string player2result = "";

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            player1point = 0;
            this.player2Name = player2Name;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

        public string GetScore()
        {
            var score = "";
            if (player1point == player2point && player1point < 3)
            {
                if (player1point == 0)
                    score = "Love";
                if (player1point == 1)
                    score = "Fifteen";
                if (player1point == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (player1point == player2point && player1point > 2)
                score = "Deuce";

            if (player1point > 0 && player2point == 0)
            {
                if (player1point == 1)
                    player1result = "Fifteen";
                if (player1point == 2)
                    player1result = "Thirty";
                if (player1point == 3)
                    player1result = "Forty";

                player2result = "Love";
                score = player1result + "-" + player2result;
            }
            if (player2point > 0 && player1point == 0)
            {
                if (player2point == 1)
                    player2result = "Fifteen";
                if (player2point == 2)
                    player2result = "Thirty";
                if (player2point == 3)
                    player2result = "Forty";

                player1result = "Love";
                score = player1result + "-" + player2result;
            }

            if (player1point > player2point && player1point < 4)
            {
                if (player1point == 2)
                    player1result = "Thirty";
                if (player1point == 3)
                    player1result = "Forty";
                if (player2point == 1)
                    player2result = "Fifteen";
                if (player2point == 2)
                    player2result = "Thirty";
                score = player1result + "-" + player2result;
            }
            if (player2point > player1point && player2point < 4)
            {
                if (player2point == 2)
                    player2result = "Thirty";
                if (player2point == 3)
                    player2result = "Forty";
                if (player1point == 1)
                    player1result = "Fifteen";
                if (player1point == 2)
                    player1result = "Thirty";
                score = player1result + "-" + player2result;
            }

            if (player1point > player2point && player2point >= 3)
            {
                score = "Advantage player1";
            }

            if (player2point > player1point && player1point >= 3)
            {
                score = "Advantage player2";
            }

            if (player1point >= 4 && player2point >= 0 && (player1point - player2point) >= 2)
            {
                score = $"Win for {player1Name}";
            }
            if (player2point >= 4 && player1point >= 0 && (player2point - player1point) >= 2)
            {
                score = $"Win for {player2Name}";
            }
            return score;
        }

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            player1point++;
        }

        private void P2Score()
        {
            player2point++;
        }
    }
}

