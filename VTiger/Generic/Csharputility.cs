using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{

    public class Csharputility
    {
        public int Randomnum() 
        {
        Random ran = new Random();
        int num=ran.Next(10,99);
        return num;
        }

        
        public string getsystemdate()
        {
            DateTime dt = DateTime.Now;
           string cdate=dt.ToString().Replace("/", "-").Replace(" ", "-");
            return cdate;    
        }
    }
}
