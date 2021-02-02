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

        public static implicit operator Member(string member)
        {
           if(!string.IsNullOrEmpty(member))
            {
                var date = member.Split(' ');
                DateTime time;
                var result = DateTime.TryParse(date[2], out time);
                return new Member(date[0], date[1], time);
            }
            else 
            {
                throw new ArgumentException("Erorrs DataofBirtch");
            }
        }

        public static implicit operator Member ((string lastname, string firstname, DateTime date) test)
        {
            if (!string.IsNullOrEmpty(test.firstname) && !string.IsNullOrEmpty(test.lastname))
            {
                return new Member(test.lastname, test.firstname, test.date);
            }
            else 
            {
                throw new ArgumentException("Erorrs DataofBirtch");
            }
        }

        public static implicit operator string(Member memb)
        {
            return $"{memb.LastName} {memb.FirstName} {memb.DateOfBirth}";
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {DateOfBirth}";
        }
    }
}
