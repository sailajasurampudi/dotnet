using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace project
{
    class CustInfo
    {
        public int CustNo;
        public string CustName;
        public int ContactNo;
    }
    class Program
    {
        public static void Main()
        {
            List<CustInfo>ICust=new List<CustInfo>();
            for(int i=0;i<5;i++){
                Console.WriteLine("Enter employee details: ");
                int ID=Convert.ToInt32(Console.ReadLine());
                string Name=Console.ReadLine();
                int Contact=Convert.ToInt32(Console.ReadLine());
                ICust.Add(new CustInfo{CustNo=ID,CustName=Name,ContactNo=Contact});
            }
            StreamWriter file=File.CreateText(@"C:\Users\VMAdmin\Desktop\sailu.txt");
            foreach(CustInfo obj in ICust){
                file.WriteLine(obj.CustNo.ToString()+","+ obj.CustName+","+obj.ContactNo.ToString());
            }
            file.Close();
        }
    }
}