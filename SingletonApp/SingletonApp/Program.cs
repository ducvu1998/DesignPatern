using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Program
    {
        static TableServers host1 = new TableServers();
        static TableServers host2 = TableServers.GetTableServers();
        class MauSac
        {
            /* Giả sử màu chủ đạo là 1 chuỗi ký tự lưu tên màu tương ứng */
            public static string MauChuDao;
            /* Dùng static constructor để kiểm tra ngày hiện tại và khởi tạo giá trị cho biến tĩnh MauChuDao */
            static MauSac()
            {
                /* Khai báo đối tượng ngày giờ và lấy ngày giờ hiện tại của hệ thống */
                DateTime now = DateTime.Now;

                /* lấy ra thứ của ngày hiện tại và so sánh với 7 ngày trong tuần */
                switch (now.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        MauChuDao = "Black";
                        break;
                    case DayOfWeek.Monday:
                        MauChuDao = "Blue";
                        break;
                    case DayOfWeek.Saturday:
                        MauChuDao = "Green";
                        break;
                    case DayOfWeek.Sunday:
                        MauChuDao = "Yellow";
                        break;
                    case DayOfWeek.Thursday:
                        MauChuDao = "Pink";
                        break;
                    case DayOfWeek.Tuesday:
                        MauChuDao = "Red";
                        break;
                    case DayOfWeek.Wednesday:
                        MauChuDao = "Purple";
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region singleton
            //string key, a, b, c;
            //
            //do
            //{

            //    Console.WriteLine("MENU");
            //    Console.WriteLine("1.Chọn kết nối");
            //    Console.WriteLine("2.Xem bài hát đang phát");
            //    //Console.WriteLine("3.Tăng âm");
            //    key = Console.ReadLine();
            //    switch (key)
            //    {
            //        case "1":
            //            string bh;
            //            TableServers tb = TableServers.GetTableServers();
            //            tb.show();
            //            do
            //            {
            //                Console.WriteLine("Chọn 1 bài hát");
            //                bh = Console.ReadLine();
            //            }
            //            while (!tb.listen(Int32.Parse(bh)));

            //            break;
            //        case "2":
            //            TableServers tb1 = TableServers.GetTableServers();
            //            tb1.listening();
            //            break;
            //        default:
            //            break;

            //    }


            //} while (key != "0");
            #endregion
            #region factory
            //     SecureFactory secure = new SecureFactory();
            ////     Connection con = new Connection();
            //     Connection conn = secure.createConnection("MYSQL");
            //     if (conn != null)
            //     {
            //         Console.WriteLine("the server connection is:" + conn.description());

            //     }
            //     else
            //     {
            //         Console.WriteLine("the server connection is:");

            //     }
            #endregion
            #region decorated
            //computer com = new computer();
            //com = new cardVGA(com);
            //com = new mainBoard(com);
            //com = new chip(com);
            //com = new chip(com);
            //Console.WriteLine("the result is:" + com.description());
            #endregion

            #region singleton

            /* Tạo một Thread t với anonymous function và gọi hàm DemoThread bên trong
             * Thread chỉ bắt đầu chạy khi gọi hàm Start
             * Bạn có thể thực hiện một hàm hay nhiều dòng code ở bên trong anonymous function này
             */
            //database db;
            //Thread t3 = new Thread(() => {
            //    db = database.getInstance();
            //    Console.WriteLine("this is:" + db.name);

            //});
            //Thread t = new Thread(() => {
            //    db = database.getInstance();
            //    Console.WriteLine("this is:" + db.name);

            //});

            //Thread t2 = new Thread(() => {
            //    db = database.getInstance();
            //    Console.WriteLine("this is:" + db.name);

            //});
            //t2.Start();
            //t3.Start();
            //t.Start();

            //Thread.Sleep(50);
            //t.Join();

            #endregion
            #region adapter
            //Ace a = new Ace();
            //a.setName("Vũ Đức");
            //AceToAcme ad = new AceToAcme(a);
            //Console.WriteLine("first name is: " + ad.getFirstName());
            //Console.WriteLine("last name is: " + ad.getLastName());
            #endregion

            #region template
            //automotiveRobot a = new automotiveRobot();
            //a.go();
            #endregion
            //   Node tree = new Node("A");
            //   tree.addLeftNode(tree,"B");
            //   tree.addRightNode(tree.firstChild, "C");
            //   tree.addRightNode(tree.firstChild.nextSibling, "D");
            //   tree.addLeftNode(tree.firstChild,"E");
            //   tree.addRightNode(tree.firstChild.firstChild,"F");

            //   tree.addLeftNode(tree.firstChild.nextSibling.nextSibling, "G");
            //   tree.addLeftNode(tree.firstChild.firstChild, "H");
            //   tree.addRightNode(tree.firstChild.firstChild.firstChild, "k");
            //  tree.addLeftNode(tree.firstChild.firstChild.nextSibling, "j");

            //  // tree_DeQui.preoder(tree, inData);
            ////   Console.WriteLine("################## ");
            //  // tree_DeQui.inoder(tree, inData);
            //   Console.WriteLine("################## ");
            //   tree_DeQui.postoder(tree, inData);
            //   Console.WriteLine("################## ");
            //   tree_NoneDeQui.postoder(tree, inData);
            //int[] ar = new int[] { 1, 9, 2, 3, 2, 0 };
            //SapXepChen(ar);
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.Write("{0}\t", ar[i]);
            //}
            // int[] s = new int[] { 1060, 6453, 1031, 3028, 3395, 2650, 441, 7937, 6605, 7410, 7296, 8514, 5568, 9779, 4161, 2365, 319, 7499, 6257, 552, 7704, 4406, 7750, 2577, 7961, 8753, 1040, 7733, 6421, 5326, 9611, 9643, 7132, 8572, 8118, 5627, 9732, 4269, 2757, 4184, 3702, 1791, 7411, 4702, 5022, 7749, 4122, 7681, 2845, 1864, 6306, 1947, 1755, 1621, 7381, 6191, 4467, 607, 1791, 5407, 1902, 1445, 4109, 8245, 9194, 7991, 4443, 9333, 2845, 9717, 9697, 5193, 9594, 2328, 7438, 6158, 1151, 1776, 5602, 9324, 4351, 3780, 9691, 2261, 4679, 4843, 5893, 5247, 9288, 7854, 9809, 2151, 4821, 6117, 8775, 8292, 120, 2482, 2513, 5211 };
            //int[] e = new int[] { 2588, 6458, 8672, 6919, 6239, 5114, 874, 9463, 7244, 8005, 7699, 8607, 9105, 9869, 5973, 4906, 5261, 8401, 9250, 8392, 8444, 5757, 9006, 3733, 8079, 8760, 3332, 8312, 9944, 6821, 9856, 9745, 7757, 9598, 8356, 7597, 9894, 6523, 3998, 4726, 4203, 4233, 8271, 7749, 9762, 8104, 6180, 8851, 8128, 1914, 9565, 7055, 3179, 8999, 8867, 7148, 6754, 881, 9069, 7820, 1910, 9680, 6245, 9213, 9281, 9655, 5354, 9790, 8852, 9957, 9851, 6381, 9623, 9335, 7749, 6563, 7137, 8915, 9860, 9594, 7691, 8058, 9704, 7898, 7371, 8780, 7750, 6653, 9493, 9642, 9966, 5589, 5747, 7649, 9040, 8541, 5013, 3979, 5747, 7534 };
            //int[] s = new int[] { 1,3 };
            //int[] e = new int[] { 3,5};
            //(98,139)(14,32)(70,93)
            //int[] s = new int[] {98,14,70,19,59,17,27,27,22,92,10,0,75,28,23,12,47,51,50,81};
            //int[] e = new int[] {139,32,93,44,78,65,61,29,115,107,41,84,98,68,32,85,75,81,123,151};
            // int[] s = new int[] { 1, 2, 4, 5 };
            //int[] s = new int[] { 4, 19, 14, 9, 7, 3, 6, 15, 13, 14 };
            //Console.Write("Gia tri la: {0}\t", MaximizeSum(s));
            HTTuyenTinh test = new HTTuyenTinh();
            Console.Write("Gia tri la: {0} - {1}\t", test.HashMod(388,11),3%11);
            Console.Write("\n\n");
            Console.ReadKey();

        }
        public static int MaximizeSum(int[] arr)
        {
            //1,2,4,3,5,6,7,9,21,34,54
            //1,2,3,4,5,6,7,9,12,21,34,54
            //1,7,2,9,3,12,4,21,5,34,6,54

            int sum = 0;
            int tmp, j;
            for (int i = 1; i < arr.Length; i++)
            {
                tmp = arr[i];
                j = i;
                while (j > 0 && tmp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = tmp;
            }
            for (int i = 0; i < (int)Math.Ceiling((double) arr.Length / 2); i++)
            {
                //sum = arr[i] - arr[(int)Math.Ceiling((double)arr.Length / 2)];
                sum += Math.Abs(arr[i] - arr[((int)Math.Ceiling((double)arr.Length / 2)+i)]);
                if(((int)Math.Ceiling((double)arr.Length / 2) + i)<arr.Length-1)
                sum += Math.Abs(arr[i+1] - arr[((int)Math.Ceiling((double)arr.Length / 2)+i)]);
                //Console.WriteLine("vi tri: {0} \t {1}\t {2}", i, ((int)Math.Ceiling((double)arr.Length / 2) + i),(i+1));
                //Console.WriteLine("so hang: {0} \t {1}\t {2}", arr[i], arr[((int)Math.Ceiling((double)arr.Length / 2) + i)], arr[i+1]);
                //Console.WriteLine("Tong: {0} ", sum);

            }
            return sum + Math.Abs(arr[0] - arr[arr.Length-1]);
        }
        public static void SapXepChen(int[] a)
        {
            int tmp, j;
            for (int i = 1; i < a.Length; i++)
            {
                tmp = a[i];
                j = i;
                while (j > 0 && tmp < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = tmp;
            }
        }
        public static int MettingRoom(int[] s, int[] e)
        {
            int tmp,tmpE, j;
            for (int i = 1; i < e.Length; i++)
            {
                tmp = s[i];
                tmpE = e[i];
                j = i;
                while (j > 0 && tmpE < e[j - 1])
                {
                    s[j] = s[j - 1];
                    e[j] = e[j - 1];
                    j--;
                }
                s[j] = tmp;
                e[j] = tmpE;
            }
            int dem = 1,k=0;
            for (int i = 1; i < s.Length; i++)
            {
               if(s[i] >= e[k])
                {
                    dem++;
                    k = i;
                }
               
            }
            return dem;
        }
        public static void inData(string data)
        {
            Console.WriteLine("node: " + data);
        }
        // Func<T, T> test() { }
        public class human
        {
            public human()
            {
                name = "Đức";
            }
            public string name { get; set; }

        }
        public static void changeName(human h)
        {
            h.name = "Hải";
        }
        public class Utility<T>
        {
            public delegate void ShowLog(T o);
        }
        private static void changeList(List<string> l)
        {
            l.Add("hello");
        }
        private static void changenuber(int l)
        {
            l = 0;
        }
        private static void Host1Server()
        {
            Console.WriteLine("the next server 1 is:" + host1.GetNextServer());
        }
        private static void Host2Server()
        {
            Console.WriteLine("the next server 2 is:" + host2.GetNextServer());
        }
    }


}
