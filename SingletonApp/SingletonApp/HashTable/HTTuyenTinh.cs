using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    internal class HTTuyenTinh
    {
        //hàm băm
        public int HashMod(int k,int SIZE)
        {
            return k % SIZE;
        }
        public int HashMultiple(int k,int SIZE,double a)
        {
            if (a == 0)
            {
                a = 0.61803399;
            }
            return (int)Math.Truncate((k*a-Math.Truncate(k*a))*SIZE);
        }
        //Hàm thăm dò tuyến tính
        public int Probing(int i,int m,int SIZE) {
            //SIZE: kích cỡ của mảng
            //i vị trí ban đầu được xđ bởi băm khóa k, i=h(k)
            //m hàm trả về vị trí thăm dò ở lần thứ  m=0,1,2,...

            return (i+m)%SIZE;
        }
    }
}
