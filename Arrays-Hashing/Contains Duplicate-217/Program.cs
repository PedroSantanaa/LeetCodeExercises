// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //Ler linha
        string input = Console.ReadLine();
        string[] inputValues = input.Split(",");
        int[] numbers = new int[inputValues.Length];
        for (int i = 0; i < inputValues.Length; i++)
        {
            numbers[i] = int.Parse(inputValues[i]);
        }

        Console.WriteLine(ContainsDuplicate(numbers));
    }
    public static bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i]==nums[j])
                {
                    return true;
                }

                
            }
        }

        return false;
    }
}