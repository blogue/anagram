using System.Collections.Generic;
using System;

namespace AnagramChecker.Objects
{
  public class Anagram
  {
    private static List<string> _result = new List<string> {};
    private static List<string> _partialAnagramResult = new List<string> {};

    public static List<string> CheckForAnagram(string word, List<string> anagrams)
    {
      char[] wordArray = word.ToCharArray();
      Array.Sort(wordArray);
      int counter = 0;
      int wordCount = wordArray.Length;
      System.Console.WriteLine(wordArray);

      for (int i = 0; i < anagrams.Count; i++)
      {
        char[] anagramWord = anagrams[i].ToCharArray();
        Array.Sort(anagramWord);
        System.Console.WriteLine(anagramWord);

        if (anagramWord.Length > wordCount)
        {
          continue;
        }
        else if (anagramWord.Length < wordCount)
        {
          for(int k=0; k < anagramWord.Length; k++)
          {
            if (Array.Exists(wordArray, element => element.Equals(anagramWord[k])))
            {
              counter++;
              if (counter != anagramWord.Length)
              {
                counter = 0;
                continue;
              }
              else if (counter == anagramWord.Length)
              {
                _result.Add(anagrams[i]);
                counter = 0;
              }
            }
          }
        }

        else
        {
          for(int j = 0; j < wordArray.Length; j++)
          {
            if (wordArray[j] == anagramWord[j])
            {
              counter++;
            }
          }

          if(counter != wordCount)
          {
            counter = 0;
            continue;
          }
          else if (counter == wordCount)
          {
            _result.Add(anagrams[i]);
            counter = 0;
          }
        }
      }
      return _result;
    }

    public static void DeleteAll()
    {
      _result.Clear();
    }
  }
}
