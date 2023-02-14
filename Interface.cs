using System;
namespace Interface14._02._2023HM
{
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
