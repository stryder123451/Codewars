using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Printer 
{
    public static string PrinterError(String s) 
    {
          
               return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
}