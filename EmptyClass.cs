using System;
namespace Interface14._02._2023HM
{
    public class EmptyClass: IOutput2, ICalc, ICalc2
    {
        
        public int[] arr = new int[5] { 3, 2, 4, 5, 6 };

        public int Less(int valueToCompare)
        {
            int Count = 0;

            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i]<valueToCompare)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
            return Count;
        }
        public int Greater(int valueToCompare)
        {
            int Count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valueToCompare)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
            return Count;
        }

        public void ShowEven()
        {
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Console.WriteLine("Четное числo-->" + arr[i]);
                }
                
            }
        
        }
        public void ShowOdd()
        {
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i]%2!=0)
                {
                    Console.WriteLine("Не четное числo-->" + arr[i]);
                }
            }
        }
        public int CountDistinct()
        {
            int Count = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                for (int j =0; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Count++;
                       
                    }
                }
                
            }
            Console.WriteLine("Количество уникальных чисел-->" + Count);
            return Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int Count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    Count++;
                    Console.WriteLine("Количество элементов массива равных твоему числу-->" + Count);
                }
            }
            return Count;
        }
    }
}
