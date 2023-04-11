using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int[] nums=new int[10] { 1, 2, 3, 4, 5, 6, 7, 15, 9, 10};
int target = 9;
int k1 = 0;
int k2 = 0;
do
{
    k2++;
    if(k2==nums.Length)
    {
        k1++;
        k2 = 0;
    }
}
while (nums[k1] + nums[k2]!=target);
Console.WriteLine($"[{k1};{k2}]");