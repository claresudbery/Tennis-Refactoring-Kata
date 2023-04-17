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
            string s;
            if ((_player1.Points < 4 && _player2.Points < 4) && (_player1.Points + _player2.Points < 6))
            {
                return GetMidGameScore();
            }
            else
            {
                if (_player1.Points == _player2.Points)
                    return "Deuce";
                s = _player1.Points > _player2.Points ? _player1.Name : _player2.Name;
                return ((_player1.Points - _player2.Points) * (_player1.Points - _player2.Points) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }

        private string GetMidGameScore()
        {
            return (_player1.Points == _player2.Points)
                ? PointsToScore(_player1.Points) + "-All"
                : PointsToScore(_player1.Points) + "-" + PointsToScore(_player2.Points);
        }

        private static string PointsToScore(int player1Points)
        {
            var points_to_score = new[] { "Love", "Fifteen", "Thirty", "Forty" };
            return points_to_score[player1Points];
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

