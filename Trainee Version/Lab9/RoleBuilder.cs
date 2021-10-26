using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9
{
    class RoleBuilder
    {
     
        private static string[] Roles = { "UNDEFINED", "DEVELOPER", "TEST_ENGINEER", "SR_DEVELOPER", "DESIGNER" };

    
        public static string GetRoleDescription(int RoleId)
        {
            if(RoleId==1)
                return Roles[1];
            else if(RoleId==2)
                return Roles[2];
            else if(RoleId==3)
                return Roles[3];
            else if(RoleId==4)
                return Roles[4];
            else
                return Roles[0];
        }
    }
}
