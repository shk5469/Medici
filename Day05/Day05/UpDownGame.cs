using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public enum UpDownGameResult { UP, DOWN, OK }

    class UpDownGame
    {
        private int com;
        public int Com
        {
            get { return com; }
            set 
            { 
                if (value < 0)
                    com = 0;
                else
                    com = value;
            }
        }

        public UpDownGame()
        {
            Random rnd = new Random();
            com = rnd.Next(1, 51);
        }

        public UpDownGame(int maxValue)
        {
            Random rnd = new Random();
            com = rnd.Next(1, maxValue + 1);
        }

        public UpDownGame(int minValue, int maxValue)
        {
            Random rnd = new Random();
            com = rnd.Next(minValue, maxValue + 1);
        }

        public UpDownGameResult Game(int user)
        {
            if (com > user)
                return UpDownGameResult.UP;
            else if (com < user)
                return UpDownGameResult.DOWN;
            else
                return UpDownGameResult.OK;
        }

    }
}
