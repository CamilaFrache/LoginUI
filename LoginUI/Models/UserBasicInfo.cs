using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUI.Models
{
    public class UserBasicInfo
    {

        public String FullName { get; set; }
        public String Email { get; set; }

        public int RoleID { get; set; }
        public string RoleText { get; set; }    
    }

    public enum RoleDetails
    {
        Writer = 1,
        Reader = 2,
    }
}
