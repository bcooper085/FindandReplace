using System;
using System.Collections.Generic;

namespace FindReplace.Objects
{
  public class FindsReplaces
  {
    public string[] stringArray;
    //
    // public FindsReplace(string startString)
    // {
    //   stringArray = new string[startString.length];
    // }


    public string FindsAndReplaces(string startString, string targetWord, string replaceWord)
    {

      stringArray = startString.Split();

      for (int i = 0; i < stringArray.Length; i++)
      {
        if (stringArray[i] == targetWord)
        stringArray[i] = replaceWord;
      }
      string output = string.Join(" ", stringArray);
      return output;
    }

  }
}
