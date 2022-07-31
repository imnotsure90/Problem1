using System;
namespace FBProblem1;

public class fb_5
{

 public static void NextPermutation(int[] nums) {


int i = nums.Length -2;

//scan i from right to left until find the smaller value 
while (i>=0)
{
if(nums[i] < nums[i+1])
break;
i--;
}

if (i != -1)   
{

int j = nums.Length -1;

while (j>i)
{

if (nums[j] >nums[i])
break;
j--;

}

var temp = nums[i];
nums[i] = nums[j];
nums[j] = temp;
int start = i+1;
int end = nums.Length -1;
while (start < end )
{
int temp1 = nums[start];
nums[start] = nums[end];
nums[end]  = temp1;
start++;
end--;


}

}

else Array.Sort(nums);

        
    }


}
