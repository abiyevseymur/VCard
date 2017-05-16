using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Card
{
    class VirtualCard
    {
        private int enterDays;

       public ulong VCardNumb()
        {
            Random rnd = new Random();
        byte[] bytes = new byte[8];
        rnd.NextBytes(bytes);
            ulong VcardNumb = BitConverter.ToUInt64(bytes, 0);
            return VcardNumb;
    }

       
    }
}
