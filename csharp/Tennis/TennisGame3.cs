namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public TennisGame3(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if ((_player1.Points < 4 && _player2.Points < 4) && (_player1.Points + _player2.Points < 6))
            {
                return GetMidGameScore();
            }
            else
            {
                string score;
                if (_player1.Points == _player2.Points)
                    return "Deuce";
                score = _player1.Points > _player2.Points ? _player1.Name : _player2.Name;
                return ((_player1.Points - _player2.Points) * (_player1.Points - _player2.Points) == 1) ? "Advantage " + score : "Win for " + score;
            }
        }

        private string GetMidGameScore()
        {
            var player1_score = PointsToString(_player1.Points);

            var score = (_player1.Points == _player2.Points)
                ? player1_score + "-All"
                : player1_score + "-" + PointsToString(_player2.Points);

            return score;
        }

        private static string PointsToString(int points)
        {
            string[] points_to_string = { "Love", "Fifteen", "Thirty", "Forty" };
            return points_to_string[points];
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _player1.Points += 1;
            else
                _player2.Points += 1;
        }

    }
}

