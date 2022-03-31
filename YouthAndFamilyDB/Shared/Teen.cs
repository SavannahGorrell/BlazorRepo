using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouthAndFamilyDB.Shared
{
    public class Teen
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeLevel { get; set; }
        public HouseChurch HouseChurch { get; set; } = new HouseChurch();

    }
}
