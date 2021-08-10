using System;
using System.Collections.Generic;
using System.Linq;

namespace project
{
    internal class Q3
    {
        public Q3()
        {
        }

        internal int[] process1(string input)
        {
            List<int> list = new List<int>();
            int n = int.Parse(input);
            if(n==1){
                n = Job(n.ToString(), list);
            }
            while (n !=1)
            {
                n = Job(n.ToString(), list);
            }
            return list.ToArray();
        }

        private int Job(string input, List<int> list)
        {
            int res = 0;
            string inp_Unery = Unery(input);
            string inp_Unery_with_hash = inp_Unery + "#";
            string odd_even = checkEven(inp_Unery_with_hash);
            if (odd_even == "even")
            {
                res = evenOpreation(inp_Unery, list);
            }
            else if(odd_even == "odd")
            {
                res = oddOpreation(inp_Unery, list);
            }
            return res;
        }

        private int oddOpreation(string inp_Unery, List<int> list)
        {
            var inp_Unery_blank = "B" + inp_Unery + "B";
            var tmp = inp_Unery_blank.ToCharArray().ToList();
            int tape = 1;



        a0:
            {
                if (tmp[tape] == '1')
                {
                    tmp[tape] = '$';
                    tape++;
                    goto a0;
                }
                if (tmp[tape] == 'B')
                {
                    tape--;
                    goto a1;
                }

            }
        a1:
            {
                if (tmp[tape] == '1')
                {
                    tape--;
                    goto a1;
                }
                if (tmp[tape] == '$')
                {
                    tmp[tape] = '1';
                    if (tape < tmp.Count)
                        tape++;
                    goto a2;
                }
                if (tmp[tape] == 'B')
                {
                    tmp[tape] = '1';
                    goto accept;
                }
            }
        a2:
            {
                if (tmp[tape] == '1')
                {
                    tape++;
                    goto a2;
                }

                if (tape == tmp.Count - 1)
                {
                    tmp.Insert(tape, '1');
                    tape++;
                    goto a3;
                }
            }
        a3:
            {
                if (tape < tmp.Count)
                {
                    if (tape == tmp.Count - 1)
                    {
                        tmp.Insert(tape, '1');
                        tape--;
                        goto a1;
                    }
                    if (tmp[tape] == '1')
                    {
                        tape++;
                        goto a3;
                    }

                }

            }
        accept:
            {
                list.Add(tmp.Count - 1);
                return tmp.Count - 1;
            }

        }

        private int evenOpreation(string inp_Unery, List<int> list)
        {
            inp_Unery = inp_Unery + 'B';
            var tmp = inp_Unery.ToCharArray();
            int tape = 0;
        t0:
            {
                if (tmp[tape] == '1')
                {
                    tmp[tape] = '#';
                    tape++;
                    goto t1;
                }
                else if (tmp[tape] == 'B')
                {
                    tape--;
                    if (tape > 0)
                        goto t2;
                }
            }
        t1:
            {
                if (tmp[tape] == '1')
                {
                    tape++;
                    goto t5;
                }
                else if (tmp[tape] == 'B')
                {
                    tape--;
                    if (tape >= 0)
                        goto t6;
                }

            }
        t2:
            {
                if (tmp[tape] == '#')
                {
                    tmp[tape] = '1';
                    tape--;
                    if (tape < 0) { goto accept; }
                    goto t2;
                }

            }
        t3:
            {
                if (tmp[tape] == '1')
                {
                    tape--;
                    if (tape >= 0)
                        goto t3;
                }
                else if (tmp[tape] == '#')
                {
                    tape++;
                    goto t0;
                }

            }
        t4:
            {
                if (tmp[tape] == '1')
                {
                    tmp[tape] = 'B';
                    tape--;
                    if (tape >= 0)
                        goto t3;
                }

            }
        t5:
            {
                if (tmp[tape] == '1')
                {
                    tape++;
                    goto t5;
                }
                if (tmp[tape] == 'B')
                {
                    tape--;
                    if (tape >= 0)
                        goto t4;
                }

            }
        t6:
            {
                if (tmp[tape] == '#')
                {
                    tmp[tape] = 'B';
                    tape--;
                    if (tape >= 0)
                        goto t7;
                }

            }
        t7:
            {
                if (tmp[tape] == '#')
                {
                    tmp[tape] = '1';
                    tape--;
                    if (tape >= 0)
                        goto t7;
                }

            }
        accept:
            {
                string result = "";
                foreach (var t in tmp)
                {
                    if (t == '1')
                    {
                        result += '1';
                    }
                }
                list.Add(result.Length);
                return result.Length;
            }


        }

        private string Unery(string input)
        {
            string st = "";
            int n = int.Parse(input);
            for (int i = 0; i < n; i++)
            {
                st += "1";
            }
            return st;
        }

        private string checkEven(string inp_copy)
        {
            var input_array = inp_copy.ToCharArray();
            int tape = 0;
        q0:
            {
                if (input_array[tape] == '1')
                {
                    tape++;
                    goto odd;
                }
                if (input_array[tape] == '#')
                {
                    goto even;
                }
            }
        odd:
            {
                if (input_array[tape] == '1')
                {
                    tape++;
                    goto q0;
                }
                else
                    return "odd";

            }
        even:
            {
                return "even";
            }
        }
    }
}