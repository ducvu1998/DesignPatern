using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    class studentController:IDisposable
    {
        IStudent studentRepo;
        public studentController()
        {
            this.studentRepo = new studentRepo("1","duc");
        }

        public void Dispose()
        {
            studentRepo.Dispose();
        }

        public void readFile()
        {
            studentRepo.writeInfor();
        }
        //protected override void Dispose(bool disposing)
        //{
        //    studentRepo.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}
