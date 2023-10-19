using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Player
    {
        private int score;

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score < 0)
                {
                    score = 0;
                }
            }
        }
    }
}
