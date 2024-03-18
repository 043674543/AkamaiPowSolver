using System.Security.Cryptography;
using System.Text;

namespace SecCptSolver
{
    public class Solver
    {
        private string Sec { get; }
        private long Timestamp { get; }
        private string Nonce { get; }
        private int Difficulty { get; set; }
        private Random Random { get; }

        public Solver(string sec, long timestamp, string nonce, int difficulty)
        {
            Sec = sec;
            Timestamp = timestamp;
            Nonce = nonce;
            Difficulty = difficulty;
            Random = new Random();
        }

        private static int Bdm(ReadOnlySpan<byte> a, int t)
        {
            int e = 0;
            foreach (var t1 in a)
            {
                e = (e << 8) | t1;
                e %= t;
            }
            return e;
        }

        public List<string> ComputePoW()
        {
            List<string> nVals = new List<string>();
            using var sha256 = SHA256.Create();
            StringBuilder sb = new StringBuilder();
            Span<byte> hash = stackalloc byte[32];

            while (nVals.Count < 10)
            {
                string n = $"0.{((long)Random.Next(int.MaxValue) << 20) | (uint)Random.Next(0xFFFFF):x13}";
                sb.Clear();
                sb.Append(Sec).Append(Timestamp).Append(Nonce).Append(Difficulty).Append(n);
                sha256.TryComputeHash(Encoding.ASCII.GetBytes(sb.ToString()), hash, out _);

                if (Bdm(hash, Difficulty) == 0)
                {
                    Difficulty++;
                    nVals.Add(n);
                }
            }

            return nVals;
        }
    }
}