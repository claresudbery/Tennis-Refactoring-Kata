namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _player2_points;
        private int _player1_points;
        private readonly string _player1_name;
        private readonly string _player2_name;

        public TennisGame3(string player1Name, string player2Name)
        {
            _player1_name = player1Name;
            _player2_name = player2Name;
        }

        public string GetScore()
        {
            string s;
            if ((_player1_points < 4 && _player2_points < 4) && (_player1_points + _player2_points < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                return (_player1_points == _player2_points) 
                    ? p[_player1_points] + "-All" 
                    : p[_player1_points] + "-" + p[_player2_points];
            }
            else
            {
                if (_player1_points == _player2_points)
                    return "Deuce";
                s = _player1_points > _player2_points ? _player1_name : _player2_name;
                return ((_player1_points - _player2_points) * (_player1_points - _player2_points) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this._player1_points += 1;
            else
                this._player2_points += 1;
        }

    }
}

