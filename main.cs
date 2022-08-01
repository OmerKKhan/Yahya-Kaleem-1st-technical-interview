using System;
using System.Collections.Generic;
// Task#1
// Given an integer x, return true if x is palindrome integer.
// An integer is a palindrome when it reads the same backward as forward.
// For example, 121 is a palindrome while 123 is not.


// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.

// Example 2:
// Input: x = 14
// Output: false
// Explanation: Reads 41 from right to left. Therefore it is not a palindrome.


class Program {

    public static void Main (string[] args) {
    //14251
    //990
    //100
    Console.WriteLine (IsPalindrome(990));
  
  }
  
  public static bool IsPalindrome(int num)
  {
    List<int> number = new List<int>();

    bool result = false;
    
    while(num/10 != 0)
    {
      number.Add(num%10);
      Console.WriteLine(num%10);
      num = num / 10;
    }
    List<int> reverse = new List<int>(number);
    reverse.Reverse();
    
    for (int i=0; i < number.Count - 1; i++)
    {
      if(number[i] == reverse[i])
      {
        result = true;
      }
      else
      {
        result = false;
      }
    }
    
    return result;
  }
}