using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tennis.Tests
{
    public class DefaultTestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0,    0,  "Love-All"          },
            new object[] {1,    1,  "Fifteen-All"       },
            new object[] {2,    2,  "Thirty-All"        },
            new object[] {3,    3,  "Deuce"             },
            new object[] {4,    4,  "Deuce"             },
            new object[] {1,    0,  "Fifteen-Love"      },
            new object[] {0,    1,  "Love-Fifteen"      },
            new object[] {2,    0,  "Thirty-Love"       },
            new object[] {0,    2,  "Love-Thirty"       },
            new object[] {3,    0,  "Forty-Love"        },
            new object[] {0,    3,  "Love-Forty"        },
            new object[] {4,    0,  "Win for player1"   },
            new object[] {0,    4,  "Win for player2"   },
            new object[] {2,    1,  "Thirty-Fifteen"    },
            new object[] {1,    2,  "Fifteen-Thirty"    },
            new object[] {3,    1,  "Forty-Fifteen"     },
            new object[] {1,    3,  "Fifteen-Forty"     },
            new object[] {4,    1,  "Win for player1"   },
            new object[] {1,    4,  "Win for player2"   },
            new object[] {3,    2,  "Forty-Thirty"      },
            new object[] {2,    3,  "Thirty-Forty"      },
            new object[] {4,    2,  "Win for player1"   },
            new object[] {2,    4,  "Win for player2"   },
            new object[] {4,    3,  "Advantage player1" },
            new object[] {3,    4,  "Advantage player2" },
            new object[] {5,    4,  "Advantage player1" },
            new object[] {4,    5,  "Advantage player2" },
            new object[] {15,   14, "Advantage player1" },
            new object[] {14,   15, "Advantage player2" },
            new object[] {6,    4,  "Win for player1"   },
            new object[] {4,    6,  "Win for player2"   },
            new object[] {16,   14, "Win for player1"   },
            new object[] {14,   16, "Win for player2"   },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class PinklishTestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0,    0,  "Love-All"          , "Like-Any"          },
            new object[] {1,    1,  "Fifteen-All"       , "Pipteen-Any"       },
            new object[] {2,    2,  "Thirty-All"        , "Flirty-Any"        },
            new object[] {3,    3,  "Deuce"             , "Juice"             },
            new object[] {4,    4,  "Deuce"             , "Juice"             },
            new object[] {1,    0,  "Fifteen-Love"      , "Pipteen-Like"      },
            new object[] {0,    1,  "Love-Fifteen"      , "Like-Pipteen"      },
            new object[] {2,    0,  "Thirty-Love"       , "Flirty-Like"       },
            new object[] {0,    2,  "Love-Thirty"       , "Like-Flirty"       },
            new object[] {3,    0,  "Forty-Love"        , "Party-Like"        },
            new object[] {0,    3,  "Love-Forty"        , "Like-Party"        },
            new object[] {4,    0,  "Win for player1"   , "Wow moo player1"   },
            new object[] {0,    4,  "Win for player2"   , "Wow moo player2"   },
            new object[] {2,    1,  "Thirty-Fifteen"    , "Flirty-Pipteen"    },
            new object[] {1,    2,  "Fifteen-Thirty"    , "Pipteen-Flirty"    },
            new object[] {3,    1,  "Forty-Fifteen"     , "Party-Pipteen"     },
            new object[] {1,    3,  "Fifteen-Forty"     , "Pipteen-Party"     },
            new object[] {4,    1,  "Win for player1"   , "Wow moo player1"   },
            new object[] {1,    4,  "Win for player2"   , "Wow moo player2"   },
            new object[] {3,    2,  "Forty-Thirty"      , "Party-Flirty"      },
            new object[] {2,    3,  "Thirty-Forty"      , "Flirty-Party"      },
            new object[] {4,    2,  "Win for player1"   , "Wow moo player1"   },
            new object[] {2,    4,  "Win for player2"   , "Wow moo player2"   },
            new object[] {4,    3,  "Advantage player1" , "Splinking player1" },
            new object[] {3,    4,  "Advantage player2" , "Splinking player2" },
            new object[] {5,    4,  "Advantage player1" , "Splinking player1" },
            new object[] {4,    5,  "Advantage player2" , "Splinking player2" },
            new object[] {15,   14, "Advantage player1" , "Splinking player1" },
            new object[] {14,   15, "Advantage player2" , "Splinking player2" },
            new object[] {6,    4,  "Win for player1"   , "Wow moo player1"   },
            new object[] {4,    6,  "Win for player2"   , "Wow moo player2"   },
            new object[] {16,   14, "Win for player1"   , "Wow moo player1"   },
            new object[] {14,   16, "Win for player2"   , "Wow moo player2"   },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class PinklishWIPTestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0,    0,  "Love-All"          , "Love-All"          },
            new object[] {1,    1,  "Fifteen-All"       , "Fifteen-All"       },
            new object[] {2,    2,  "Thirty-All"        , "Thirty-All"        },
            new object[] {3,    3,  "Deuce"             , "Juice"             },
            new object[] {4,    4,  "Deuce"             , "Juice"             },
            new object[] {1,    0,  "Fifteen-Love"      , "Fifteen-Love"      },
            new object[] {0,    1,  "Love-Fifteen"      , "Love-Fifteen"      },
            new object[] {2,    0,  "Thirty-Love"       , "Thirty-Love"       },
            new object[] {0,    2,  "Love-Thirty"       , "Love-Thirty"       },
            new object[] {3,    0,  "Forty-Love"        , "Forty-Love"        },
            new object[] {0,    3,  "Love-Forty"        , "Love-Forty"        },
            new object[] {4,    0,  "Win for player1"   , "Win for player1"   },
            new object[] {0,    4,  "Win for player2"   , "Win for player2"   },
            new object[] {2,    1,  "Thirty-Fifteen"    , "Thirty-Fifteen"    },
            new object[] {1,    2,  "Fifteen-Thirty"    , "Fifteen-Thirty"    },
            new object[] {3,    1,  "Forty-Fifteen"     , "Forty-Fifteen"     },
            new object[] {1,    3,  "Fifteen-Forty"     , "Fifteen-Forty"     },
            new object[] {4,    1,  "Win for player1"   , "Win for player1"   },
            new object[] {1,    4,  "Win for player2"   , "Win for player2"   },
            new object[] {3,    2,  "Forty-Thirty"      , "Forty-Thirty"      },
            new object[] {2,    3,  "Thirty-Forty"      , "Thirty-Forty"      },
            new object[] {4,    2,  "Win for player1"   , "Win for player1"   },
            new object[] {2,    4,  "Win for player2"   , "Win for player2"   },
            new object[] {4,    3,  "Advantage player1" , "Advantage player1" },
            new object[] {3,    4,  "Advantage player2" , "Advantage player2" },
            new object[] {5,    4,  "Advantage player1" , "Advantage player1" },
            new object[] {4,    5,  "Advantage player2" , "Advantage player2" },
            new object[] {15,   14, "Advantage player1" , "Advantage player1" },
            new object[] {14,   15, "Advantage player2" , "Advantage player2" },
            new object[] {6,    4,  "Win for player1"   , "Win for player1"   },
            new object[] {4,    6,  "Win for player2"   , "Win for player2"   },
            new object[] {16,   14, "Win for player1"   , "Win for player1"   },
            new object[] {14,   16, "Win for player2"   , "Win for player2"   },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class TennisTests
    {
        [Theory]
        [ClassData(typeof(DefaultTestDataGenerator))]
        public void Tennis1Test(int p1, int p2, string expected)
        {
            var game = new TennisGame1("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        [Theory]
        [ClassData(typeof(PinklishTestDataGenerator))]
        public void Tennis2Test_English(int p1, int p2, string expectedEnglish, string expectedPinklish)
        {
            var game = new TennisGame2("player1", "player2");
            CheckAllScores(game, p1, p2, expectedEnglish);
        }

        [Theory]
        [ClassData(typeof(PinklishWIPTestDataGenerator))]
        public void Tennis2Test_Pinklish(int p1, int p2, string expectedEnglish, string expectedPinklish)
        {
            var game = new TennisGame2("player1", "player2", isPinklish: true);
            CheckAllScores(game, p1, p2, expectedPinklish);
        }

        [Theory]
        [ClassData(typeof(DefaultTestDataGenerator))]
        public void Tennis3Test(int p1, int p2, string expected)
        {
            var game = new TennisGame3("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        private void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }

            Assert.Equal(expectedScore, game.GetScore());
        }
    }
}