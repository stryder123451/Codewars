using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class HumanTimeFormat{
  public static string formatDuration(int Seconds)
  {
    {
              
                int Sec = 0;
                int Minutes = 0;
                int Hours = 0;
                int Days = 0;
                int Years = 0;
                List<string> Date = new List<string>();
                string Response = "";            
               

                if (Seconds == 0)
                {
                    Response = "now";
                }
                else
                {
                    while (Seconds != 0)
                    {
                        if (Seconds < 60)
                        {
                            Sec = Seconds;
                            Seconds = 0;
                        }
                        if (Seconds > 60 & Seconds <= 3600)
                        {
                            Minutes = Seconds / 60;
                            Seconds = Seconds - (Minutes * 60);
                        }
                        if (Seconds > 3600 & Seconds <= 86400)
                        {
                            Hours = Seconds / 3600;
                            Seconds = Seconds - (Hours * 3600);
                        }
                        if (Seconds > 86400 & Seconds <= 31536000)
                        {
                            Days = Seconds / 86400;
                            Seconds = Seconds - (Days * 86400);
                        }
                        if (Seconds > 31536000)
                        {
                            Years = Seconds / 31536000;
                            Seconds = Seconds - (Years * 31536000);
                        }

                    }
                    if (Years != 0)
                    {
                        if (Years == 1)
                        {
                            Date.Add(Years + " year");
                        }
                        else
                        {
                            Date.Add(Years + " years");
                        }
                        
                    }
                    if (Days != 0)
                    {
                        if (Days == 1)
                        {
                           Date.Add(Days + " day");
                        }
                        else
                        {
                            Date.Add(Days + " days");
                        }
                    }
                    if (Hours != 0)
                    {
                        if (Hours == 1)
                        {
                            Date.Add(Hours + " hour");
                        }
                        else
                        {
                            Date.Add(Hours + " hours");
                        }
                    }
                    if (Minutes != 0)
                    {
                        if (Minutes == 1)
                        {
                           Date.Add(Minutes + " minute");
                        }
                        else
                        {
                            Date.Add(Minutes + " minutes");
                        }
                    }
                    if (Sec != 0)
                    {
                        if (Sec == 1)
                        {
                            Date.Add(Sec + " second");
                        }
                        else
                        {
                            Date.Add(Sec + " seconds");
                        }
                        
                    }

                    for (int i = 0; i < Date.Count(); i++)
                    {
                         if (Date.Count == 1)
                        {
                            Response += Date[i];
                            break;
                        }
                        if (i == Date.Count - 1 & Date.Count != 1)
                        {
                            Response += "and " + Date[i];
                        }
                        else
                        {
                            if (i == Date.Count - 2 & Date.Count != 1)
                            {
                                Response += Date[i] + " ";
                            }
                            else
                            {
                                Response += Date[i] + ", ";
                            }
                        }
                    }
                  
                  
                   } 
                   return (Response);  //Creater of this task real pervert 
                   }
                   
  }
}