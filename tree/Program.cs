using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{  
    class Program
    {
        List<Member> myMembers = new List<Member>();
        public void Run()
        {
            var mamber = new Member("Larry", "Smit", new DateTime(1, 2, 3));
            var Larry = new Member("Alex", "Smit", new DateTime(1, 2, 3));
            var Marry = new Member("Tom", "", new DateTime(1, 2, 3));
            var Marry3 = new Member("Ivy", "2", new DateTime(1, 2, 3));
            var Marry4 = new Member("Lia", "2", new DateTime(1, 2, 3));
            var Marry2 = new Member("Victor", "2", new DateTime(1, 2, 3));
            var Larry2 = new Member("Maria", "Smit", new DateTime(1, 2, 3));
            var Lia = new Member("Foxy", "2", new DateTime(1, 2, 3));
            var Foxy = new Member("Bob", "2", new DateTime(1, 2, 3));
            var Foxy2 = new Member("Sonya", "2", new DateTime(1, 2, 3));
            var Charly = new Member(Foxy,Lia, "Charly", "2", new DateTime(1, 2, 3));

            myMembers.AddRange(new List<Member> { mamber, Larry, Marry2,Lia });
            mamber.AddChildren(Charly);
            
            mamber.AddChildren(Larry);
            mamber.AddChildren(Larry2);

            Larry2.AddChildren(Marry);
            Larry2.AddChildren(Marry2);
            Larry2.AddChildren(Marry3);
            Larry2.AddChildren(Marry4);

            Larry.AddChildren(Marry3);
            Larry.AddChildren(Marry4);

            Marry4.AddChildren(Lia);

            Lia.AddChildren(Foxy);
            Lia.AddChildren(Foxy2);

            ShowTree(mamber, 0);
        }
        void ShowTree(Member myMember=null, int Level=0)
    {
            if (myMember == null)
            {
                for (int i = 0; i < myMembers.Count; i++)
                {
                    var curMamber = myMembers[i];
                    if (curMamber.ParentDad == null && curMamber.ParentMom == null)
                    {
                        myMember = curMamber;
                        break;
                    }
                }
            }
            //myMember = myMember ?? myMembers.FirstOrDefault(m => m.ParentDad == null && m.ParentMom == null);
            if (myMember == null)
                return;
        Level++;

        Console.WriteLine($"{myMember.LastName}");

        foreach (var item in myMember.Clildrens)
        {
            for (int i = 0; i < Level; i++)
            {
                Console.Write("   ");
            }

            Console.Write("|---");
            ShowTree(item, Level);
        }

    }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Run();
            Console.WriteLine("Enter 1 more relative- press eny 1");
            string chose = Console.ReadLine();
            bool isContinue = true;
            while (isContinue)
            {
                switch (chose)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter lastName");
                            string lName = Console.ReadLine();
                            Console.WriteLine("Enter firstName");
                            string fName = Console.ReadLine();
                            var x = new Member(lName, fName);
                            Console.WriteLine("Enter the first name of parent");
                            string parentName = Console.ReadLine();

                            //var foundParent = pro.myMembers.FirstOrDefault(m => m.LastName == parentName);

                            Member foundParent = null;
                            foreach (var memb in pro.myMembers)
                            {
                                if (memb.LastName == parentName)
                                {
                                    foundParent = memb;
                                    break;
                                }
                            }

                            if (foundParent != null)
                            {
                                foundParent.AddChildren(x);
                                pro.myMembers.Add(x);
                                pro.ShowTree();
                            }
                            
                            Console.WriteLine("continue yes? no- press eny key?");
                            if(Console.ReadLine() != "yes")
                            isContinue = false;
                            

                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
