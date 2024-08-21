//default initialize
int[] numbers;
numbers = new int[5] { 1, 2, 3, 4, 5 };

//outher default initialize
int[] numbers1 = { 1, 2, 3, 4, 5 };

//get indices
int[] getNumber = new int[3];  //memory alocation
getNumber[0] = numbers1[0];


//access array using for structure
for (int i = 0; i < numbers1.Length; i++)
{
    Console.WriteLine(numbers1[i]);
}

//access array using foreach structure
foreach (int number in numbers1)
{
    Console.WriteLine(number);
}

int value = Array.BinarySearch(numbers1, 1);

Console.WriteLine("================ multidimensional arrays ================");

//two-dimensional array declaration
int[,] twoDimensional;
twoDimensional = new int[3, 3] {
    { 0, 1, 2 },
    { 3, 4, 5 },
    { 6, 7, 8 }
};
//access the two-dimensional array
Console.WriteLine(twoDimensional[2,2]);

//access the two-dimensional array with for structure
Console.WriteLine("================================");
for (int i = 0; i < twoDimensional.GetLength(0); i++)
{
    for (int j = 0; j < twoDimensional.GetLength(1); j++)
    {
        Console.Write($"{twoDimensional[i, j]} ");
    }
    Console.WriteLine();
}


Console.WriteLine("================================");
foreach (int number in twoDimensional)
{
    Console.WriteLine(number);
}

Console.ReadKey();