using System;
namespace FBProblem1
{

public class fb_3
{
//Integer to Roman
   public static string IntToRoman(int num) {

    string result ="" ;

    while (num > 0)
                {
                    if (num - 1000>=0)
                    {
                        result =result + "M";
                        num = num - 1000;
                        
                       
                    }
                    else  if (num - 900>=0)
                    {
                        result = result + "CM";
                         num = num - 900;
                    }
                       else  if (num - 500>=0)
                    {
                        result = result + "D";
                         num = num - 500;
                    }
                       else  if (num - 400>=0)
                    {
                        result = result + "CD";
                         num = num - 400;
                    }
                       else  if (num - 100>=0)
                    {
                        result = result + "C";
                         num = num - 100;
                    }
                       else  if (num - 90>=0)
                    {
                        result = result + "XC";
                         num = num - 90;
                    }
                       else  if (num - 50>=0)
                    {
                        result = result + "L";
                         num = num - 50;
                    }
                       else  if (num - 40>=0)
                    {
                        result = result + "XL";
                         num = num - 40;
                    }
                       else  if (num - 10>=0)
                    {
                        result = result + "X";
                         num = num - 10;
                    }
                       else  if (num - 9>=0)
                    {
                        result = result + "IX";
                         num = num - 9;
                    }
                       else  if (num - 5>=0)
                    {
                        result = result + "V";
                         num = num - 5;
                    }
                       else  if (num - 4>=0)
                    {
                        result = result + "IV";
                         num = num - 4;
                    }
                       else  if (num - 1>=0)
                    {
                        result = result + "I";
                         num = num - 1;
                    }
                  
                }


return result;

   }

   public static string IntToRoman2(int num) {

Dictionary<int, string> romanTable = new Dictionary<int, string>(); 
romanTable[1000] = "M";   
romanTable[900] = "CM";       
romanTable[500] = "D";  
romanTable[400] = "CD";            
romanTable[100] = "C";  
romanTable[90] = "XC";  
romanTable[50] = "L";   
romanTable[40] = "XL";        
romanTable[10] = "X";   
romanTable[9] = "IX"; 
romanTable[5] = "V";    
romanTable[4] = "IV";         
romanTable[1] = "I";   

string result ="" ;   
int currIndex = 0;

while (num>0)

 {
            while(num>=romanTable.Keys.ElementAt(currIndex))
            {
                result+=romanTable.Values.ElementAt(currIndex);
                num-=romanTable.Keys.ElementAt(currIndex);
            }
            currIndex++;
        }
        return result;
   }        

public static int RomanToInt(string s)
{
int result =0;
Dictionary<int,string>  romanTable = new Dictionary<int, string>();
romanTable[1000] = "M";   
romanTable[900] = "CM";       
romanTable[500] = "D";  
romanTable[400] = "CD";            
romanTable[100] = "C";  
romanTable[90] = "XC";  
romanTable[50] = "L";   
romanTable[40] = "XL";        
romanTable[10] = "X";   
romanTable[9] = "IX"; 
romanTable[5] = "V";    
romanTable[4] = "IV";         
romanTable[1] = "I";   


  for (int i = 0; i < s.Length -1; i++)
        {    

            if  (romanTable.Values.Contains(s[i..(i+2)].ToString()))  
            {
                 result += romanTable.FirstOrDefault(x => x.Value ==s[i..(i+2)].ToString()).Key;
             i=i+1;
             if (i == s.Length -1)
              return result;
                                    
            }

            else
            {
                 result += romanTable.FirstOrDefault(x => x.Value ==s[i].ToString()).Key;                
                                    
            }

  
        }
       
            result += romanTable.FirstOrDefault(x => x.Value ==s[s.Length -1].ToString()).Key;       
        
     
    return result;
}


}
}