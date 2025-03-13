using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo
{
    public class GlobalVar
    {
        public static string permission = "";
        public static int userID = 0;
        public static int tableID = 0;
        //public static string image_dir = @"C:\Users\iSpan\Desktop\CY\Project\image";
        public static string image_dir = @"D:\桌面\資策會\CY\Project\image";
        public static string strDBConnectionString = "";
        public static DateTime StartTime = DateTime.Now;
        public static TimeSpan TimePass = new TimeSpan(0, 0, 0);
        public static List<ArrayList> cart = new List<ArrayList>();
        public static List<int> OrderTotal = new List<int>();
        public static int Total = 0;
        public static int OrderNum = 0;
        public static int SearchID = 0;
        public static string selectMode = "";
        public static string page = "";
    }
}
