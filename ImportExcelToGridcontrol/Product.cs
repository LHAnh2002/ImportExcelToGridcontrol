using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExcelToGridcontrol
{
    class Product
    {
        public int STT { get; set; } 

        public int Id { get; set; }
        public string Name { get; set; }
        public int Pow  { get; set; }
        public int Killt4 { get; set; }
        public int Killt5 { get; set; }
        public int Die { get; set; }
        public int Point { get; set; }

        public Product(int id, string name, int pow,int killt4,int killt5,int die, int point)
        {
            Id = id;
            Name = name;
            Pow = pow;
            Killt4 = killt4;
            Killt5 = killt5;
            Die = die;
            Point = point;
        }
        public Product(int stt,int id, string name, int pow, int killt4, int killt5, int die, int point)
        {
            
            STT = stt;
            Id = id;
            Name = name;
            Pow = pow;
            Killt4 = killt4;
            Killt5 = killt5;
            Die = die;
            Point = point;
        }
    }
}
