namespace AlgorithmsAndDataStructure.Lib;

public static class Sort
{
    /*
     O OBJETIVO DESTA CLASSE É REUNIAR OS PRINCIPAIS ALGORITMOS DE ORDENAÇÃO:
        - BUBBLE SORT
        - INSERTION SORT
        - SELECT SORT
        - MERGE SORT
        - QUICK SORT
     */


    public static int[] BubbleSort(int[] nums)
    {
        int length = nums.Length;
        int aux;

        for(int i = 0; i < length - 1; i++)
        {
            for(int j = 0; j < length - 1 - i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    aux = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = aux;
                }
            }
        }

        return nums;
    }
}
