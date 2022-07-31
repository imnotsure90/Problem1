using System;
namespace FBProblem1
{

public class fb_1
{

    public  static int LengthOfLongestSubstring(string s)  
    //A static method (or static function) is a method defined as a member of 
    //an object but is accessible directly from an API object's constructor, rather than from an object instance created via the constructor
{
    Dictionary<char, int> prevAppearance = new Dictionary<char, int>(); 
    //You use Dictionary<TKey,TValue> when you need to store values with some unique keys 
    //associated to them, and accessing them by that key is convenient for you.
    int maxSubstringLength = 0;
        int prevNonRepeatingSubstringStartIndex = 0;
        //we could define a mapping of the characters to its index to tell if a character exists or not. 
        //Then we can skip the characters immediately when we found a repeated character.
        //creat a Dictionary which stores the characters in string as keys and their positions as values,
        //SET 2 POINTER AT BEGINNING, AND 1 MOVE TO THE RIGHT
        for (int i = 0; i < s.Length; i++)
        {            
            if (prevAppearance.Keys.Contains(s[i]))  
            {
                prevNonRepeatingSubstringStartIndex =
                //move pointer after duplicate CHARACTER
                    Math.Max(prevAppearance[s[i]]+1, prevNonRepeatingSubstringStartIndex);      
                                     
            }
            maxSubstringLength =
                Math.Max(maxSubstringLength, i - prevNonRepeatingSubstringStartIndex + 1);  //UPDATE THE MAX AGAINST CURRENT MAX
            prevAppearance[s[i]] = i; //ADD THE CHRACTERS/UPDATE THE INDEX FOR DUP CHARACTER
        }
        
        return maxSubstringLength;
        //Time complexity : O(n). Index j will iterate n times.
        //Space complexity (Table): O(m). m is the size of the charset.
}

/*     public static int LengthOfLongestSubstring(string s) 
{
    Dictionary<char, int> letters = new Dictionary<char, int>();
    int length = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (letters.TryGetValue(s[i], out int index))
        {
            length = Math.Max(length, letters.Count);
            i = index;
            letters.Clear();
        }
        else
        {
            letters.Add(s[i], i);
        }
    }
    length = Math.Max(length, letters.Count);
    return length;
}*/
}

}