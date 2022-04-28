using LoginExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExample.Controller
{
    public class LoginController
    {
        public string UserPassword(string username)
        {
            using (LoginDBEntities ex = new LoginDBEntities())
            {
                var exsistingStudent = ex.Students.Where(s => s.Username == username).FirstOrDefault();
                if(exsistingStudent != null)
                {
                    return exsistingStudent.Password;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
