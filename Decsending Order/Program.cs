using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
                string s = num.ToString();                            
                char[] Order = s.ToCharArray();              
                string Response = "" ;              
                List<int> Numbers = new List<int>();               
                foreach (char value in Order)
                {
                    for (int i = 0; i < 1; i++)
                    {   int OutNum;
                        Int32.TryParse(value.ToString(),out OutNum);
                        Numbers.Add(OutNum);
                    }
                }

                Numbers.Sort();
                Numbers.Reverse();
                foreach (int Sym in Numbers)
                {
                    Response += Sym.ToString();
                }
                return Convert.ToInt32(Response);
  }
}