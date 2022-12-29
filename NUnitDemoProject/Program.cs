using NUnitDemoProject;

Console.WriteLine("Input array length: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0)
{
    Console.WriteLine("Invalid array size!");
    return 1;
}

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
   Console.WriteLine("Input array item number {0}: ", i); 
   int item = Convert.ToInt32(Console.ReadLine());
   array[i] = item;
}

try
{
    SortSamples.SimpleBubbleSort(array);
    Console.WriteLine("Sorted Array:");
    foreach (var item in array)
    {
       Console.Write("{0} ", item); 
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine("Array is empty");
    return 1;
}

return 0;