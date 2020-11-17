using System;

namespace Project14
{
    class Episode
    {
        private int Views;
        private float Rating_sum = 0;
        private float Highest_rating = 0;
        private float Avg_rating;
        TvUtilities Description = new TvUtilities();
        


        public Episode(float score)
        {
            this.Rating_sum += score;
        }

        public Episode()
        {
            
        }

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

        
    }
}
