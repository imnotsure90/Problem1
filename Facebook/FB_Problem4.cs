using System;
namespace FBProblem1
{

public class fb_4
{
//3Sum
//Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
//Notice that the solution set must not contain duplicate triplets.

//Questions: Do We need to do validation check if nums = null or <3?
//Algo:
//Complex:

   public static IList<IList<int>> ThreeSum(int[] nums) {


 var reslist = new List<IList<int>>();
if(nums == null || nums.Length < 3)
            return reslist;

Array.Sort(nums);
// / {-9,2,7,11};
//-2,-1,0,1,2,3

                
Dictionary <int,int> map = new Dictionary<int, int>{};
//[]
//11 3
// 7 2
// 2 1
//-9 0
  for (int i = nums.Length - 1; i >= 0; i--)
        if (!map.ContainsKey(nums[i]))
            map[nums[i]] = i;
//

for (int i =0; i < nums.Length -1 ;i ++)
{
 if((nums[0] > 0) ||  (i > 0 && nums[i - 1] == nums[i]) ) //skip dup 
                continue;
 for (int j = i + 1; j < nums.Length -1; j++) {
         if (j > i + 1 && nums[j] == nums[j - 1]) continue; //skip dup

         var t = 0 - nums[i] - nums[j];

if(t > nums[j] && map.ContainsKey(t)) ///we sort array from small to large so t alway > - nums[j]
{

 reslist.Add(new List<int>(){nums[i], nums[j], t});


}
 else if (t == nums[j] && nums[j + 1] == t) reslist.Add(new [] {nums[i], t, t}); // in case in put  = [0,0,0]
 }

}
  return reslist;
}

   

// /https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
//Questions:
//Algo:
//Complex:
// dic[key] = value
     public static int[] TwoSum2(int[] numbers, int target) {
        
Dictionary <int,int> map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length ;i++)
        {
if( map.ContainsKey(target - numbers[i]))
{
return new int [] {map[target - numbers[i]]+1,i+1};

}
else 
if (!map.ContainsKey(numbers[i]))
map.Add(numbers[i],i);
        }
        return new int[2];
     }



//2 sum

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.
    public static int[] TwoSum(int[] nums, int target) {
        
            if(nums == null || nums.Length < 2)
            return new int[2];
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i]))
                return new int[]{i, dic[target - nums[i]]};
            else if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }
        
        return new int[2];
    }

//Remove Duplicates from Sorted Array
// /https://leetcode.com/explore/interview/card/facebook/5/array-and-strings/3011/

     public static int RemoveDuplicates(int[] nums) {
int k = 0;
int numsLen = nums.Length;

for ( int i =1; i < numsLen; i++)
{
if (nums[i] == nums[i-1]) 

k++;

else (nums[i-k]) =nums[i];

}
return numsLen-k;

// if (nums == null || nums.Length == 0)
//             return 0;
        
//         int i = 0;
        
//         for (int j = 0; j < nums.Length; j++)
//         {
//             nums[i++] = nums[j];
            
//             while (j < nums.Length - 1 && nums[j] == nums[j + 1])
//                 j++;
//         }
        
//         return i;
        
    }
}
}