using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    /// <summary>
    /// Create partial class Member
    /// Metods
    /// </summary>
    partial class Member
    {
        //Add new Children
        public void AddChildren(Member myMember)
        {
            Clildrens.Add(myMember);
        }
        //Add Father
        public void AddFather(Member myMember)
        {
            ParentDad = myMember;
        }
        //Add Mother
        public void AddMother(Member myMember)
        {
            ParentMom = myMember;
        }
        // Create new Famaly
        public static Famaly operator +(Member member1, Member member2)
        {
            return new Famaly(member1, member2);
        }
        //Add Data
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
        // Create  from text to member
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
        // from member to text
        public static implicit operator string(Member memb)
        {
            return $"{memb.LastName} {memb.FirstName} {memb.DateOfBirth}";
        }
        /// <summary>
        ///method override ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{LastName} {FirstName} {DateOfBirth}";
        }
    }
}
