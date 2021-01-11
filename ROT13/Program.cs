using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static string Rot13(string input)
  {
                byte [] Dec = ASCIIEncoding.UTF8.GetBytes(input.ToCharArray());
                string NewWord = "";
                foreach (Byte b in Dec)
                {
                    if (Char.IsLetter((char)b) == true)
                    {
                        int NewNumber = 0;
                        if (b >= 65 & b <= 90)
                        {
                            if (b <= 77)
                            {
                                NewNumber = (int)b + 13;
                                NewWord += (char)NewNumber;
                            }
                            else
                            {
                                NewNumber = (int)b - 13;
                                NewWord += (char)NewNumber;
                            }
                        }
                        if (b >= 97 & b <= 122)
                        {
                            if (b <= 109)
                            {
                                NewNumber = (int)b + 13;
                                NewWord += (char)NewNumber;
                            }
                            else
                            {
                                NewNumber = (int)b - 13;
                                NewWord += (char)NewNumber;
                            }
                        }
                    }
                    else
                    {
                        NewWord += (char)b;
                    }
                }
                 return NewWord;
  }
}