using System;

namespace project
{
    internal class Q2
    {
        public Q2(){}
        internal string process2(string input)
        {
            input = input.ToLower();
            string ALLOWED = "ALLOWED";
            string REJECTED = "REJECTED";
            ///add blanks as B to first and last
            string inputwithBalnk = 'B' + input + "BB";
            var inputarray = inputwithBalnk.ToCharArray();
            ///initial tape position
            int tape = 1;
            //////////////////////////////////////////////////////////////////////q0
            if (inputarray[tape] == 'a')
            {
                inputarray[tape] = 'B';
                tape++;
                goto q1;
            }
            else if (inputarray[tape] == 'B')
            {
                tape++;
                goto rejected;
            }
            else { goto rejected; }
        ////////////////////////////////////////////////////////////////////////q1
        q1:
            {
                if (inputarray[tape] == 'x')
                {
                    tape++;
                    goto q1;
                }
                else if (inputarray[tape] == 'B')
                {
                    tape++;
                    goto accepted;
                }
               else if (inputarray[tape] == 'a')
                {
                    inputarray[tape] = 'x';
                    tape++;
                    goto q2;
                }
                else goto rejected;
            }
        //////////////////////////////////////////////////////////////////////////q2
        q2:
            {
                if (inputarray[tape] == 'x')
                {
                    tape++;
                    goto q2;
                }
                else if (inputarray[tape] == 'B')
                {
                    tape--;
                    goto q4;
                }
                else if (inputarray[tape] == 'a')
                {
                    tape++;
                    goto q3;
                }
                else goto rejected;
            }
        ////////////////////////////////////////////////////////////////////////q3
        q3:
            {
                 if (inputarray[tape] == 'a')
                {
                    inputarray[tape] = 'x';
                    tape++;
                    goto q2;
                }
                else if (inputarray[tape] == 'x')
                {
                    tape++;
                    goto q3;
                }
                else if (inputarray[tape] == 'B')
                {
                    tape++;
                    goto rejected;
                }
                else goto rejected;
            }
        ////////////////////////////////////////////////////////////////////////q4
        q4:
            {
                if (inputarray[tape] == 'x')
                {
                    tape--;
                    goto q4;
                }
               else if (inputarray[tape] == 'a')
                {
                    tape--;
                    goto q4;
                }
                else if (inputarray[tape] == 'B')
                {
                    tape++;
                    goto q1;
                }
                else goto rejected;
            }
        ///////////////////////////////////////////////////////////////////qaccept
        accepted: return ALLOWED;
        //////////////////////////////////////////////////////////////////qreject
        rejected: return REJECTED;
        }
    }
}