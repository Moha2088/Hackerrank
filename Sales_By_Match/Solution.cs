using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

internal class Solution
{
    static void Main(string[] args)
    {
        static int sockMerchant(int n, List<int> ar)
        {
            foreach (int sock in ar)
            {
                List<int> DistinctSocks = ar.Distinct().ToList();

                foreach (int distinctSock in DistinctSocks)
                {
                    if (sock == distinctSock)
                    {
                        ar.Remove(sock);
                    }
                }
            
            // var printPairs = from item in ar;
            }

            return 0;
        }
    }
}