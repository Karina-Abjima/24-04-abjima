using System;
class Program

{
    static int? Sum1(List<int>? numbers)//using a nullable list 
    {
        if (numbers == null || numbers.Count == 0)
        {
            return null;
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
    static void NullExample()
    {
        List<string>? nullableList = null;

        try
        {
            List<string> nonNullableList = nullableList ?? throw new ArgumentNullException(nameof(nullableList), "Input value is null");

            nonNullableList.Add("item 1");
            nonNullableList.Add(null); // this will trigger an ArgumentNullException

            Console.WriteLine("The non-nullable list contains the following items:");
            foreach (string item in nonNullableList)
            {
                Console.WriteLine("- " + item);
            }
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected exception occurred: " + ex.Message);
        }
    }


    static int? Sum(int? x, int? y)

    {

        if (x.HasValue && y.HasValue)

        {

            return x.Value + y.Value;

        }

        else

        {

            return null;

        }

    }


    static void Main()

    {

        int? a = 10;

        int? b = null;



        int? result = Sum(a, b);



        if (result.HasValue)

        {

            Console.WriteLine("The sum is: " + result.Value);

        }

        else

        {

            Console.WriteLine("One or both values are null.");

        }

        List<int>? numbers = new List<int>() { 1, 2, 3, 4, 5 };//nullable list

        int? result1 = Sum1(numbers);

        if (result.HasValue)
        {
            Console.WriteLine("The sum is: " + result1.Value);
        }
        else
        {
            Console.WriteLine("The list is empty or null.");
        }
        NullExample();

    }

}




