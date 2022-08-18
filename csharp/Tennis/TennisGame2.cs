namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private string _player1_name;
        private string _player2_name;

        private int _player1_points;
        private int _player2_points;

        private string _player1_result = "";
        private string _player2_result = "";

        public TennisGame2(string player1Name, string player2Name)
        {
            this._player1_name = player1Name;
            _player1_points = 0;
            this._player2_name = player2Name;
        }

        public void WonPoint(string player)
        {
            if (player == _player1_name)
                P1Score();
            else
                P2Score();
        }

        public string GetScore()
        {
            var score = "";
            if (_player1_points == _player2_points && _player1_points < 3)
            {
                if (_player1_points == 0)
                    score = "Love";
                if (_player1_points == 1)
                    score = "Fifteen";
                if (_player1_points == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (_player1_points == _player2_points && _player1_points > 2)
                score = "Deuce";

            if (_player1_points > 0 && _player2_points == 0)
            {
                if (_player1_points == 1)
                    _player1_result = "Fifteen";
                if (_player1_points == 2)
                    _player1_result = "Thirty";
                if (_player1_points == 3)
                    _player1_result = "Forty";

                _player2_result = "Love";
                score = _player1_result + "-" + _player2_result;
            }
            if (_player2_points > 0 && _player1_points == 0)
            {
                if (_player2_points == 1)
                    _player2_result = "Fifteen";
                if (_player2_points == 2)
                    _player2_result = "Thirty";
                if (_player2_points == 3)
                    _player2_result = "Forty";

                _player1_result = "Love";
                score = _player1_result + "-" + _player2_result;
            }

            if (_player1_points > _player2_points && _player1_points < 4)
            {
                if (_player1_points == 2)
                    _player1_result = "Thirty";
                if (_player1_points == 3)
                    _player1_result = "Forty";
                if (_player2_points == 1)
                    _player2_result = "Fifteen";
                if (_player2_points == 2)
                    _player2_result = "Thirty";
                score = _player1_result + "-" + _player2_result;
            }
            if (_player2_points > _player1_points && _player2_points < 4)
            {
                if (_player2_points == 2)
                    _player2_result = "Thirty";
                if (_player2_points == 3)
                    _player2_result = "Forty";
                if (_player1_points == 1)
                    _player1_result = "Fifteen";
                if (_player1_points == 2)
                    _player1_result = "Thirty";
                score = _player1_result + "-" + _player2_result;
            }

            if (_player1_points > _player2_points && _player2_points >= 3)
            {
                score = $"Advantage {_player1_name}";
            }

            if (_player2_points > _player1_points && _player1_points >= 3)
            {
                score = $"Advantage {_player2_name}";
            }

            if (_player1_points >= 4 && _player2_points >= 0 && (_player1_points - _player2_points) >= 2)
            {
                score = $"Win for {_player1_name}";
            }
            if (_player2_points >= 4 && _player1_points >= 0 && (_player2_points - _player1_points) >= 2)
            {
                score = $"Win for {_player2_name}";
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
            _player1_points++;
        }

        private void P2Score()
        {
            _player2_points++;
        }
    }
}

