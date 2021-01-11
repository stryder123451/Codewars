using System;

public class Kata
{
  public static string PigIt(string Sentence)
  {
                
                string[] Words = Sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string NewWord = "";
                foreach (string Word in Words)
                {
                    char[] Letters = Word.ToCharArray();
                    char ExSymbol = Letters[0];
                    for (int i = 0; i < Word.Length-1; i++)
                    {                                   
                        Letters[i] = Letters[i + 1];
                        NewWord += Letters[i].ToString();
                        if (i == Word.Length-2)
                        {
                            NewWord += ExSymbol+"ay"+" ";
                        }
                    }
                 
                }
                return NewWord.Remove(NewWord.Length-1);
  }
}