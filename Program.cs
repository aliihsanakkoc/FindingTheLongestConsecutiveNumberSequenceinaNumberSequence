using System.Collections;
using System.Net;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 503, 504, 3, 1, 2, 121, 122, 3, 124, 128, 130, 140, 141, 142, 143 };
        FindingTheLongestConsecutiveNumberSequenceinaNumberSequence(nums);
    }
static void FindingTheLongestConsecutiveNumberSequenceinaNumberSequence(Array arr){
        Array.Sort(arr);
        List<int> ints = new List<int>();
        for(int i = 0; i < arr.Length; i++){
            if(ints.Contains((int)arr.GetValue(i)))
                continue;
            ints. Add((int)arr.GetValue(i));
        } 
        ints.Add(ints.LastOrDefault()+2);  //If it's the last one, Trigger for Finding TheLongestConsequtiveArray
        List<int> longestConsecutiveInts = new List<int>();
        List<int> templongestConsecutiveInts = new List<int>();
        for(int i = 1; i < ints.Count; i++){
            if(ints[i] - ints[i-1] == 1 ){
                if( templongestConsecutiveInts.Count > 0)
                    templongestConsecutiveInts.Add(ints[i]);
                else{ templongestConsecutiveInts.Add(ints[i-1]);
                      templongestConsecutiveInts.Add(ints[i]);
                }
            }
            else{ if( longestConsecutiveInts.Count > templongestConsecutiveInts.Count)
                      templongestConsecutiveInts.Clear();
                else{ longestConsecutiveInts.Clear();
                      longestConsecutiveInts.AddRange(templongestConsecutiveInts);
                      templongestConsecutiveInts.Clear();
                }
            }
        }
        Console.WriteLine($"The Longest Consequtive Array Length : {longestConsecutiveInts.Count}");
        foreach (var item in longestConsecutiveInts){Console.WriteLine(item);}
    } 
}
