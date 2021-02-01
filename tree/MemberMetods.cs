using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    partial class Member
    {
        public void AddChildren(Member myMember)
        {
            Clildrens.Add(myMember);
        }

        public void AddFather(Member myMember)
        {
            ParentDad = myMember;
        }
        public void AddMother(Member myMember)
        {
            ParentMom = myMember;
        }

        public static Famaly operator +(Member member1, Member member2)
        {
            return new Famaly(member1, member2);
        }

        public static implicit operator Member(DateTime data)
        {
            return new Member { DateOfBirth = data };
        }
    }
}
