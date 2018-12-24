using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] lStrArr = str.Split('_', '-');
    
    for (int i = 1; i < lStrArr.Length; i++)
    {
      char[] lConvert = lStrArr[i].ToCharArray();
      lConvert[0] = char.ToUpper(lConvert[0]);
      lStrArr[i] = new string(lConvert);
    }
    
    string result = String.Join("", lStrArr);
    
    return result;
  }
}