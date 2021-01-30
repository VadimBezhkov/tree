﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Member : Person
    {
        public Member ParentDad { get; set; }
        public Member ParentMom { get; set; }
        public List<Member> Clildrens { get; private set; }

        public Member(string lastName, string firstName) :base (lastName,firstName)
        {
            Clildrens = new List<Member>();
        }
        public Member(string lastName, string firstName, DateTime dateOfBirth)
            : base(lastName, firstName, dateOfBirth)
        {
            Clildrens = new List<Member>();
        }

        public Member(Member Dad, Member Mom, string lastName, string firstName, DateTime dateOfBirth)
            : this(lastName, firstName, dateOfBirth)
        {
            ParentDad = Dad;
            ParentMom = Mom;
        }

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
            ParentMom= myMember;
        }

        public static Famaly operator +(Member member1, Member member2)
        {
            return new Famaly (member1, member2);
        }
    }
}
