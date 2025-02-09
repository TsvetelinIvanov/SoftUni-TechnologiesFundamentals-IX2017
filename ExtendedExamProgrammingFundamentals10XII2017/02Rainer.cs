using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputTrackAndIndex = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int index = inputTrackAndIndex[inputTrackAndIndex.Count - 1];
            inputTrackAndIndex.RemoveAt(inputTrackAndIndex.Count - 1);
            
            List<int> track = new List<int>(inputTrackAndIndex);
            int donaldStepsCount = 0;
            bool isDonaldWet = false;
            while (true)
            {                
                for (int i = 0; i < track.Count; i++)
                {
                    track[i]--;
                    if (track[i] == 0 && i == index)
                    {                       
                        isDonaldWet = true;                       
                    }                    
                }
                
                if (isDonaldWet)
                {
                    break;
                }                    

                for (int i = 0; i < track.Count; i++)
                {
                    if (track[i] == 0)
                    {
                        track[i] = inputTrackAndIndex[i];
                    }
                }

                donaldStepsCount++;
                index = int.Parse(Console.ReadLine());                
            }           
                         
            Console.WriteLine(string.Join(" ", track));           
            Console.WriteLine(donaldStepsCount);            
        }
    }
}
