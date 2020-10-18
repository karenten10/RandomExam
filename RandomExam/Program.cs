using System;

namespace RandomExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // 宣告一個random變數
            var rand = new Random();

            // 範例1
            // 產生一個亂數（整數）
            //var randInt1 = rand.Next();
            //Console.WriteLine($"===> rand1 = {randInt1}");

            // 範例2
            // 產生一個亂數（0-99整數)
            //var randInt2 = rand.Next(100);
            //Console.WriteLine($"===> rand2 = {randInt2}");

            // 範例3
            // 產生一個亂數（0-9整數)
            //var randInt10 = rand.Next(0, 10);
            //Console.WriteLine($"===> rand10 = {randInt10}");

            // 產生一個亂數（10-19整數)
            //var randInt20 = rand.Next(10, 20);
            //Console.WriteLine($"===> rand20 = {randInt20}");

            // 範例4
            // 給我5個亂數 (0-99整數)
            //for (var i = 0; i < 5; i++)
            //{
            //    var currentRandInt = rand.Next(0, 100);
            //    Console.WriteLine($"===> currentRandInt => {currentRandInt}");
            //}

            generateNewName();

        }

        public static void generateNewName()
        {
            var rand = new Random();

            string[] FirstNames = {
                "Adam", "Brecon", "Courtney", "Debbie", "Eason"
            };
            string[] LastNames = {
                "McLaws", "Sorenson", "Kinikini", "Harrison", "Gessler"
            };

            var firstRand = rand.Next(0, 5);
            var lastRand = rand.Next(0, 5);

            string newName = $"{FirstNames[firstRand]} {LastNames[lastRand]}";

            Console.WriteLine($"===> A new name is \"{newName}\".");
        }
    }
}
