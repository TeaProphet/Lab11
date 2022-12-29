namespace NUnitDemoProject;

public class SortSamples
{
   public static void SimpleBubbleSort(int[] array)
   {
      if (array.Length == 0)
      {
         throw new InvalidDataException();
      }

      for (int i = 0; i < array.Length - 1; i++)
      {
         for (int j = 0; j < array.Length - i - 1; j++)
         {
            if (array[j] > array[j + 1])
            {
               var tmp = array[j];
               array[j] = array[j + 1];
               array[j + 1] = tmp;
            }
         } 
      }
   }
}