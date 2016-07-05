using Xunit;
using System;
using System.Collections.Generic;
using AnagramChecker.Objects;

namespace AnagramChecker
{
  public class AnagramCheckerTest : IDisposable
  {
    [Fact]
    public void AnagramChecker_Test()
    {
      string testWord = "bread";
      List<string> testList = new List<string> {"beard", "bread", "abred", "bird", "drabe"};
      List<string> returnList = Anagram.CheckForAnagram(testWord, testList);
      List<string> anagramList = new List<string> {"beard", "bread", "abred", "drabe"};
      Assert.Equal(anagramList, returnList);
    }
    public void Dispose()
    {
      Anagram.DeleteAll();
    }
  }
}
