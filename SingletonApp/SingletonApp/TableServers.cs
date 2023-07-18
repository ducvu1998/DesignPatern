using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;
        private int crrServer = 0;
        public TableServers()
        {
            servers = new List<string>() { "Baby", "Dẫu có lỗi lầm", "tha thứ", "cầu vồng khuyết" };
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer++;
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
        public void show()
        {
            for (int i = 0; i < servers.Count; i++)
            {
                Console.WriteLine("{0}," + servers[i], i + 1);
            }
        }
        public bool listen(int i)
        {

            if (i >= servers.Count)
            {
                Console.WriteLine("Không tìm thấy bài hát");
                return false;
            }
            crrServer = i-1;
            Console.WriteLine("Đang chạy bài hát: " + servers[crrServer]);

            return true;
        }
        public void listening()
        {
            Console.WriteLine("Đang chạy bài hát: " + servers[crrServer]);
        }
    }
}
