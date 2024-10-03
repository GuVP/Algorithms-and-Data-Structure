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

    public static int[] BubbleSort(int[] num)
    {
        int length = num.Length;

        for(int i = 0; i < length - 1; i++)
        {
            for(int j = 0; j < length - 1 - i; j++)
            {
                if (num[j] > num[j + 1])
                {
                    int aux = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = aux;
                }
            }
        }

        return num;
    }

    public static int[] InsertionSort(int[] num)
    {
        int length = num.Length;
        int i = 1;

        while (i < length)
        {
            int j = i;
            int reference = num[i];

            while( j > 0 && num[j-1] > reference)
            {
                num[j] = num[j-1];
                j--;
            }

            num[j] = reference;
            i++;
        }

        return num;
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
