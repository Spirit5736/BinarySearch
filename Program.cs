int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 18, 35, 47, 56, 78, 89, 99 };
Console.WriteLine(FindValue(list, 35));

int? FindValue(int[] list, int item)
{
    int lowValue = 0;
    int highValue = list.Length - 1;

    while (lowValue <= highValue)
    {
        int midValue = (lowValue + highValue) / 2;
        int guess = list[midValue];

        if (guess == item)
        {
            return midValue;
        }
        if (guess < item)
        {
            lowValue = midValue + 1;
        }
        else
        {
            highValue = midValue - 1;
        }
    }
    return null;
}
