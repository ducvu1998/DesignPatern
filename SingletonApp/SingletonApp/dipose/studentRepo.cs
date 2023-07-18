using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonApp
{
    class studentRepo:IStudent,IDisposable
    {
        private MemoryStream mem=new MemoryStream(100);
        private string id;
        private string name;
        public studentRepo(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void writeInfor()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "file_dinh_kem");
            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
            //Creates a directory(folder) if it doesen't exist
            Directory.CreateDirectory(path);
            string fileSavePath = Path.Combine(path, "path.txt");
            FileStream createStream = File.Create(@fileSavePath);
            string[] lines =
        {
            "First line", "Second line", "Third line"
        };
            createStream.Close();

            File.WriteAllLines(fileSavePath, lines);
          //  var o = new
          //  {
          //      id = this.id,
          //      name = this.name
          //  };
          ////  mem=SerializeToStream(o);
          //  mem.WriteTo(createStream);
           
          //  
          //  //  MemoryStream stream = SerializeToStream(car);
          //  System.IO.File.WriteAllBytes(fileSavePath, mem.ToArray());
        }
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    mem.Dispose();
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~studentRepo() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

      
        #endregion
    }
}
