using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingInventoryManagement

{
    public class User
    {
        public void Writefile(int userId, string fName, string lName, string email, long phone)
        {
            FileStream fileStreamobj = new FileStream(@"D:\CSFiles\user.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.Write("User Id - " + userId + "," + " ");
            streamWriterobj.Write("First Name - " + fName + "," + '\t');
            streamWriterobj.Write("Last Name - " + lName + "," + '\t');
            streamWriterobj.Write("Email - " + email + "," + " ");
            streamWriterobj.WriteLine("Mob. No. - " + phone);
            streamWriterobj.Close();
            fileStreamobj.Close();
            return;
        }
    }
}