internal class Solution
{
    static void Main(string[] args)
    {
        static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int houseStartpoint = s;
            int houseEndpoint = t;
            int appleTreeLocation = a;
            int orangeTreeLocation = b;

            List<int> ApplesInZone = new();
            List<int> OrangesInZone = new();


            foreach (int item in apples)
            {
                if (item > 0 && item >= houseStartpoint && item <= houseEndpoint)
                {
                    ApplesInZone.Add(item);
                }
            }

            foreach (int item in oranges)
            {
                if (item < 0 && item <= houseEndpoint && item >= houseStartpoint)
                {
                    OrangesInZone.Add(item);
                }
            }

            Console.WriteLine(ApplesInZone.Count);
            Console.WriteLine(OrangesInZone.Count);
        }

        // Function Tests    
        
        List<int> TestA = new()
        {
            2,6,2
        };

        List<int> TestB = new()
        {
            12,4,4
        };

        countApplesAndOranges(1, 22, 4, 12,TestA,TestB);
    }
}