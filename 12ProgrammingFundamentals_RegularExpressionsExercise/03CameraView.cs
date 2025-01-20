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
            int[] skipAndTake = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int skip = skipAndTake[0];
            int take = skipAndTake[1];

            string view = Console.ReadLine();
            string camera = @"\|<";            
            string[] views = Regex.Split(view, camera);

            List<string> cameraViews = new List<string>();            
            for (int i = 1; i <= views.Length - 1; i++)
            {
                string fullView = views[i];
                if (skip < fullView.Length)
                {
                    string cameraView = DoCameraViewFromFullView(fullView, skip, take);
                    cameraViews.Add(cameraView);
                }
            }

            Console.WriteLine(string.Join(", ", cameraViews));
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
