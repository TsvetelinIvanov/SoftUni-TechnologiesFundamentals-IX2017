using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skipAndTake = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int skip = skipAndTake[0];
            int take = skipAndTake[1];

            string view = Console.ReadLine();
            string camera = @"\|<";            
            string[] viewes = Regex.Split(view, camera);

            List<string> camerasViewes = new List<string>();            
            for (int i = 1; i <= viewes.Length - 1; i++)
            {
                string fullView = viewes[i];
                if (skip < fullView.Length)
                {
                    string cameraView = DoCameraViewFromFullView(fullView, skip, take);
                    camerasViewes.Add(cameraView);
                }
            }

            Console.WriteLine(string.Join(", ", camerasViewes));
        }

        private static string DoCameraViewFromFullView(string fullView, int skip, int take)
        {
            int viewLength = fullView.Length;
            char[] fullViewArray = fullView.ToCharArray();
            char[] cameraViewArray = fullViewArray.Skip(skip).Take(Math.Min(take, viewLength - skip)).ToArray();
            string cameraView = new string(cameraViewArray);

            return cameraView;
        }
    }
}
