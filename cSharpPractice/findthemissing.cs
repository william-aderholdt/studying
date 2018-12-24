 public static char FindMissingLetter(char[] array)
  {
    char lResult = 'a';
    
    for (int i = 0; i < array.Length; i++)
    {
      if (((int)array[0] + i) != (int)array[i])
      {
        lResult = (char)((int)array[0] + i);
        return lResult;
      }
    }
    return lResult;
  }
}