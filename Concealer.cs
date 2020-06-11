using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Concealer : IKosmetik
    {
        public void JenisBenda()
        {
            Console.WriteLine("Concealer atau color corrector adalah jenis kosmetik yang digunakan Pada Wajah");
            Console.WriteLine("Concealer atau color corrector adalah jenis kosmetik yang digunakan untuk menutupi lingkaran hitam di bawah mata, bintik-bintik hitam karena usia, pori besar, serta kekurangan kecil lainnya yang terlihat di kulit wajah.");
        }
    }
}
