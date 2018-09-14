using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WordCounter.Models
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
      _word = input.ToLower();
    }

    public string GetWord()
    {
      return _word;
    }

    public string[] StringToArray()
    {
      string lowerCase = _string.ToLower();
      string [] stringArray = Regex.Split(lowerCase, @"\W|\s");
      return stringArray;
    }

    public int HowManyMatches()
    {
      string[] words = StringToArray();
      _word.ToLower();

      for(int i = 0; i < words.Length; i ++)
      {
        _matches += (_word == words[i]) ? 1 : 0;
      }

      return _matches;
    }
  }
}
