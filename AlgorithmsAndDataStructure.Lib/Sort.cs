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


    public static int[] BubbleSort(int[] numArray)
    {
        int length = numArray.Length;

        for(int i = 0; i < length - 1; i++)
        {
            for(int j = 0; j < length - 1 - i; j++)
            {
                if (numArray[j] > numArray[j + 1])
                {
                    int aux = numArray[j];
                    numArray[j] = numArray[j + 1];
                    numArray[j + 1] = aux;
                }
            }
        }

        return numArray;
    }

    public static int[] SelectionSort(int[] num)
    {
        int length = num.Length;

        for(int i = 0; i < length; i++)
        {
            int min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (num[j] < num[min])
                {
                    min = j;
                }
            }

            if(min != i)
            {
                int aux = num[i];
                num[i] = num[min];
                num[min] = aux;
            }
        }

        return num;
    }
}
