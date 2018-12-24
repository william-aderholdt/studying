using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    int[] lIntArray = numbers.ToArray();

    for (int i = 1; i < lIntArray.Length - 1; i++)
    {
      if (lIntArray[0] != lIntArray[i] && lIntArray[i] != lIntArray[i + 1])
      {
        return lIntArray[i];
      }

    }
    return lIntArray[0];
  
  }
  
}