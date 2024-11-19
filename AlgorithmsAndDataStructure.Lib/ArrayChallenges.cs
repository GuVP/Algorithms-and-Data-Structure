namespace AlgorithmsAndDataStructure.Lib
{
    public static class ArrayChallenges
    {
        public static int GreatestAverageReview(int[][] reviews)
        {
            reviews = reviews.OrderBy(x => x[0]).ToArray();

            int[][] reviewCounter = new int[reviews.DistinctBy(x => x[0]).Count()][];
            int reviewCounterIndex = -1;

            int lastEvaluatedReviewsIndex = -1;

            double greatestAverage = double.MinValue;
            int indexOfGA = -1;

            for (int i = 0; i < reviews.Length; i++)
            {
                if (reviews[i][0] != lastEvaluatedReviewsIndex)
                {
                    reviewCounterIndex++;
                }

                if (IsNewIndex(reviewCounter, reviews[i][0]))
                {
                    reviewCounter[reviewCounterIndex] = new int[] { reviews[i][0], 1, reviews[i][1]};
                }
                else
                {

                    reviewCounter[reviewCounterIndex] = new int[] { reviews[i][0], reviewCounter[reviewCounterIndex][1]+1, reviewCounter[reviewCounterIndex][2]+reviews[i][1]};
                }

                if ((double)reviewCounter[reviewCounterIndex][2]/reviewCounter[reviewCounterIndex][1] > greatestAverage)
                {
                    greatestAverage = (double)reviewCounter[reviewCounterIndex][2] / reviewCounter[reviewCounterIndex][1];
                    indexOfGA = reviewCounterIndex;
                }

                lastEvaluatedReviewsIndex = reviews[i][0];
            };

            return reviewCounter[indexOfGA][0];
        }

        private static bool IsNewIndex(int[][] reviews, int index)
        {
            return reviews.FirstOrDefault(x => x!=null && x[0] == index) == default;
        }
    }
}
