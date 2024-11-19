using AlgorithmsAndDataStructure.Lib;

namespace NumbersAPI.PrimeEngineLib.Test
{
    public class ArrayChallengesTest
    {
        private List<(int[][], int)> GreatestAverageReviewTestCases {  get; set; }

        public ArrayChallengesTest()
        {
            GreatestAverageReviewTestCases = new List<(int[][], int)>() 
            {
                (new int[][]
                {
                    new int[]{9521024, 3},
                    new int[]{9551223, 2},
                    new int[]{9521024, 4},
                    new int[]{5124521, 3},
                    new int[]{8754615, 2},
                    new int[]{5124521, 4},
                }, 5124521)
            };
        }

        [Fact]
        public void GreatestAverageReview()
        {
            foreach(var testCase in GreatestAverageReviewTestCases)
            {
                //Função de média de avaliação
                int result = ArrayChallenges.GreatestAverageReview(testCase.Item1);

                Assert.Equal(testCase.Item2, result);
            }
        }
    }
}
