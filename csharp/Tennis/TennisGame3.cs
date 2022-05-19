namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _player2Points;
        private int _player1Points;
        private string _player1Name;
        private string _player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this._player1Name = player1Name;
            this._player2Name = player2Name;
        }

        public string GetScore()
        {
            if (InMiddleOfGame())
            {
                return GetMidGameScore();
            }
            else
            {
                return GetDeuceOrAdvantageOrWinScore();
            }
        }

        private string GetDeuceOrAdvantageOrWinScore()
        {
            string s;
            if (_player1Points == _player2Points)
                return "Deuce";
            s = _player1Points > _player2Points ? _player1Name : _player2Name;
            return ((_player1Points - _player2Points) * (_player1Points - _player2Points) == 1)
                ? "Advantage " + s
                : "Win for " + s;
        }

        private string GetMidGameScore()
        {
            string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
            return (_player1Points == _player2Points)
                ? p[_player1Points] + "-All"
                : p[_player1Points] + "-" + p[_player2Points];
        }

        private bool InMiddleOfGame()
        {
            return (_player1Points < 4 && _player2Points < 4) && (_player1Points + _player2Points < 6);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this._player1Points += 1;
            else
                this._player2Points += 1;
        }

    }
}

