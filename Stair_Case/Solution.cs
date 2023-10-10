namespace StairCase
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            static void staircase(int n)
            {
                // 1. Udfyld et array med (n - 1) antal spaces, slut med en * og print indholdet ud
                
                List<string> Spaces = new List<string>();

                for (int j = 0; j < n - 1; j++)
                {
                    Spaces.Add(" ");
                }

                Spaces.Add("*");

                var firstStep = string.Join("", Spaces);
                Console.WriteLine(firstStep);

                // 2. Fjern et space og erstat det med en * og print den ud, og fortsæt indtil: n = 0
                
                for (int j = n; j > 1; j--)
                {
                    Spaces.Remove(" ");
                    Spaces.Add("*");

                    var remainingSteps = string.Join("", Spaces);
                    Console.WriteLine(remainingSteps);
                }
            }

            staircase(3);
        }
    }
}