using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingInventoryManagement
{
    public class Category
    {
        public void Writefile(long categoryId, string categoryType)
        {
            FileStream fileStreamobj = new FileStream(@"D:\CSFiles\Category.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.Write("Category Id - " + categoryId + "," + " ");
            streamWriterobj.WriteLine("Category Type - " + categoryType);
            streamWriterobj.Close();
            fileStreamobj.Close();
            return;
        }
    }
}