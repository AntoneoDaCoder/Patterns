using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Database
    {
        private static Database Instance;
        public int Num { get; set; }
        Database(int num)
        {
            Num = num;
        }
        static public Database GetInstance()
        {
            if (Instance == null)
                Instance = new Database(5);
            return Instance;
        }

    }
}
