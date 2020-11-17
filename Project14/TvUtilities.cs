using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14
{
    class TvUtilities
    {
        private int episodeNumber;
        TimeSpan episodeLenght;
        string episodeName;


        public double GenerateRandomScore()
        {
            Random rnd = new Random();
            double Min_value = 0.0;
            double Max_value = 10.0;

            double random_num = rnd.NextDouble() * (Max_value - Min_value) + Min_value;

            return random_num;
        }


    }
}
