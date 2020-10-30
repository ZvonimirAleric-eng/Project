using System;

namespace Project14
{
    class Episode
    {
        private int Views;
        private float Rating_sum = 0;
        private float Highest_rating = 0;
        private float Avg_rating;

        public float GetMaxScore()
        {
            return this.Highest_rating;
        }

        public void AddView( float rating )
        {
            this.Views++;
            Rating_sum += rating;
            if(rating > Highest_rating)
            {
                Highest_rating = rating;
            }
        }

        public float GetAverageScore()
        {
            Avg_rating = (Rating_sum / (float)Views);

            return Avg_rating;
        }

        public int GetViewerCount()
        {
            return this.Views;
        }

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
