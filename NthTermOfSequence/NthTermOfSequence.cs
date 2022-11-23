namespace NthTermOfSequence;

class NthTermOfSequence
{
    static void Main(string[] args)
    {
        string error = "Error: Invalid input. Please enter a natural number.";
        string tooHigh = "Error: The number is too high. Please enter a number below 38.";
        int input;
        try
        {
            input = int.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.WriteLine(error);
                return;
            }

            if (input >= 38)
            {
                Console.WriteLine(tooHigh);
                return;
            }

            int elementValueIter = IterativeFunction(input);
            int elementValueRec = RecursiveFunction(input);
            Console.WriteLine($"The {input}th element of the sequence is {elementValueIter}. (By iteration)");
            Console.WriteLine($"The {input}th element of the sequence is {elementValueRec}. (By recursion)");
        }
        catch
        {
            Console.WriteLine(error);
            return;
        }
    }

    static int IterativeFunction(int input)
    {
        int[] elements;
        if (input > 3)
        {
            elements = new int[input];
        }
        else
        {
            elements = new int[3];
        }

        elements[0] = 2;
        elements[1] = 4;
        elements[2] = 6;

        int elementValue = elements[input - 1];

        for (int i = 3; i < elements.Length; i++)
        {
            elementValue = 3 * elements[i - 3] + 4 * elements[i - 2] - 7 * elements[i - 1];
            elements[i] = elementValue;
        }

        return elementValue;
    }

    static int RecursiveFunction(int input)
    {
        if (input == 1)
        {
            return 2;
        }
        else if (input == 2)
        {
            return 4;
        }
        else if (input == 3)
        {
            return 6;
        }
        else
        {
            return 3 * RecursiveFunction(input - 3) + 4 * RecursiveFunction(input - 2) -
                   7 * RecursiveFunction(input - 1);
        }
    }
}