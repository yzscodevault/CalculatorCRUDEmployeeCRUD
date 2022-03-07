using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Assignment5._1
{
    enum Department
    {
        IT, HR, PR, Legal, Market, Supply, RD
    }
    enum Title
    {
        Manger, [Description("Vice Mange")]ViceManager, TeamLeader, TeamMember
    }

    class EmployeeClass
    {
        public ulong Eid { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public byte Age { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
        public Title Title { get; set; }
        public string Note { get; set; }
    }
}
