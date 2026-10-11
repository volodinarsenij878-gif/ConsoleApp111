using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program68
{
    internal class Program
    {
        static void Main()
        {
            double raw = 3.99;

            // 1. Явное приведение (усечение)
            int cast = (int)raw;

            // 2. Округление до ближайшего целого
            int rounded = (int)Math.Round(raw);

            // 3. Округление вниз (floor)
            int floor = (int)Math.Floor(raw);

            // 4. Округление вверх (ceiling)
            int ceiling = (int)Math.Ceiling(raw);

            Console.WriteLine($"raw = {raw}");
            Console.WriteLine($"(int)      → {cast}");      // 3  (усечение)
            Console.WriteLine($"Math.Round → {rounded}");   // 4  (округление)
            Console.WriteLine($"Math.Floor → {floor}");     // 3  (вниз)
            Console.WriteLine($"Math.Ceiling→ {ceiling}");  // 4  (вверх)
        }
    }
}


