using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> trains = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "It's Training Men!")
            {
                if (input.Contains("->") && input.Contains(" : "))
                {
                    string[] trainData = input.Split(new string[] { " -> ", " : " }, StringSplitOptions.None);
                    string trainName = trainData[0];
                    string wagonName = trainData[1];
                    long wagonPower = long.Parse(trainData[2]);
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }

                    trains[trainName][wagonName] = wagonPower;
                }
                else if (input.Contains(" -> "))
                {
                    string[] trainData = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string trainName = trainData[0];
                    string otherTrainName = trainData[1];
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }

                    foreach (KeyValuePair<string, long> wagon in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }

                    trains.Remove(otherTrainName);
                }
                else if (input.Contains(" = "))
                {
                    string[] trainData = input.Split(new string[] { " = " }, StringSplitOptions.None);
                    string trainName = trainData[0];
                    string otherTrainName = trainData[1];
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }

                    trains[trainName].Clear();
                    foreach (KeyValuePair<string, long> wagon in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> train in trains.OrderByDescending(t => t.Value.Values.Sum()).ThenBy(t => t.Value.Count))
            {
                Console.WriteLine("Train: " + train.Key);
                foreach (KeyValuePair<string, long> wagon in train.Value.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine("###{0} - {1}", wagon.Key, wagon.Value);
                }
            }
        }
    }
}
