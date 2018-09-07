using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _string;
    private string _word;
    private int _matches = 0;

    public void SetString(string input)
    {
      _string = input;
    }

    public string GetString()
    {
      return _string;
    }

    public void SetWord(string input)
    {
      _word = input;
    }

    public string GetWord()
    {
      return _word;
    }

    public string[] StringToArray()
    {
      return _string.Split(' ');
    }

    public int HowManyMatches()
    {
      string[] words = StringToArray();

      for(int i = 0; i < words.Length - 1; i ++)
      {
        _matches += (_word == words[i]) ? 1 : 0;
      }

      return _matches;
    }
  }
}
