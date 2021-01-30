using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
   public  class Famaly
    {
        public string NameFamaly { get; private set; }
        public Famaly(Member member1, Member member2)
        {
            NameFamaly = $"{member1.LastName} and {member2.LastName}";
        }
    }
}
