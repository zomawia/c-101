using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Name
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string FullName
        {
            get
            {
                string full = FullName;

                if (middleName != string.Empty)
                {

                }

                if (lastName != string.Empty)
                {

                }

                return full;
            }
            set
            {
                string[] names = value.Split(' ');

                if(names.Count() == 3)
                {
                    firstName = names[0];
                    middleName = names[1];
                    lastName = names[2];
                }

                else if (names.Count() == 2)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = names[1];
                }

                else if (names.Count() == 1)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = "";
                }                
            }
        }

        public string Initials
        {
            get
            {
                string f = firstName[0].ToString();
                string l = "";
                string m = "";

                if (middleName != null)
                {
                    m = middleName[0].ToString();
                }


                if (lastName[0].ToString() != "")
                {
                    l = lastName[0].ToString();
                }
                return f + m + l;
            }
        }

        //public string this [int i]
        //{
        //    get
        //    {
        //        switch (i)
        //        {
        //            case 0:
        //                return firstName;
        //                break;
        //            case 1:
        //                return middleName;
        //                break;
        //            case 2:
        //                return lastName;
        //                break;
        //        }
        //    }
        //}
    }
}
