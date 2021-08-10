using System;
using System.Collections.Generic;

namespace project
{
    internal class Q1
    { public Q1(){}
        internal string process1(string input)
        {
            string ALLOWED = "ALLOWED";
            string REJECTED = "REJECTED";
            Stack<char> tempstack = new Stack<char>();
            Stack<char> totalstack = new Stack<char>();
            var size = input.Length;
            input = input.ToLower();
            if (size == 0)
                return ALLOWED;
            int counter = 0;
            /////////////////////////////////////q0
            {
                if(input[counter]=='a'){
                    tempstack.Push('a');
                    totalstack.Push('a');
                    goto q1;
                }
                else if(input[counter]=='b'){
                    tempstack.Push('b');
                    totalstack.Push('b');
                    goto q2;
                }
                else if(input[counter]=='c'){
                    tempstack.Push('c');
                    totalstack.Push('c');
                    goto q3;
                }
                else goto reject;
            }
            /////////////////////////////////////q1
            q1:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'){
                    tempstack.Push('a');
                    totalstack.Push('a');
                    goto q1;
                }
                if(input[counter]=='b'){
                    totalstack.Push('b');
                    tempstack.Pop();
                    goto q11;
                }
                if(input[counter]=='c'){
                    totalstack.Push('c');
                    tempstack.Pop();
                    goto q13;
                }
            }
            q11:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'){goto reject;}
                 if(input[counter]=='b'){
                    totalstack.Push('b');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q11;
                }
                if(input[counter]=='c'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q12;

                }
            }
            q12:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'||input[counter]=='b'){goto reject;}
                if(input[counter]=='c'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q12;
                }
            }
            q13:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'){goto reject;}
                 if(input[counter]=='c'){
                    totalstack.Push('c');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q13;
                }
                 if(input[counter]=='b'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q14;
                }
            }
            q14:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'||input[counter]=='c'){goto reject;}
                if(input[counter]=='b'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q14;
                }  
            }
            /////////////////////////////////////q2
            q2:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='b'){
                    tempstack.Push('b');
                    totalstack.Push('b');
                    goto q2;
                }
                if(input[counter]=='a'){
                    totalstack.Push('a');
                    tempstack.Pop();
                    goto q21;
                }
                if(input[counter]=='c'){
                    totalstack.Push('c');
                    tempstack.Pop();
                    goto q23;
                }
            }
            q21:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='b'){goto reject;}
                 if(input[counter]=='a'){
                    totalstack.Push('a');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q21;
                }
                if(input[counter]=='c'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q22;

                }
            }
            q22:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'||input[counter]=='b'){goto reject;}
                if(input[counter]=='c'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q22;
                }
            }
            q23:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='b'){goto reject;}
                 if(input[counter]=='c'){
                    totalstack.Push('c');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q23;
                }
                 if(input[counter]=='a'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q24;
                }
            }
            q24:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='b'||input[counter]=='c'){goto reject;}
                if(input[counter]=='a'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q24;
                }  
            }
            /////////////////////////////////////q3
            q3:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='c'){
                    tempstack.Push('c');
                    totalstack.Push('c');
                    goto q3;
                }
                if(input[counter]=='a'){
                    totalstack.Push('a');
                    tempstack.Pop();
                    goto q31;
                }
                if(input[counter]=='b'){
                    totalstack.Push('b');
                    tempstack.Pop();
                    goto q33;
                }
            }
            q31:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='c'){goto reject;}
                 if(input[counter]=='a'){
                    totalstack.Push('a');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q31;
                }
                if(input[counter]=='b'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q32;

                }
            }
            q32:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='a'||input[counter]=='c'){goto reject;}
                if(input[counter]=='b'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q32;
                }
            }
            q33:{
                counter ++;
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='c'){goto reject;}
                 if(input[counter]=='b'){
                    totalstack.Push('b');
                    if(tempstack.Count==0){goto reject;}
                    tempstack.Pop();
                    goto q33;
                }
                 if(input[counter]=='a'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q34;
                }
            }
            q34:{
                counter++;
                if(counter==size &&totalstack.Count==0&&tempstack.Count==0){goto accept;}
                if(counter==size &&(totalstack.Count!=0||tempstack.Count!=0)){goto reject;}
                if(input[counter]=='b'||input[counter]=='c'){goto reject;}
                if(input[counter]=='a'){
                    if(tempstack.Count!=0){goto reject;}
                    if(totalstack.Count==0){goto reject;}
                    totalstack.Pop();
                    goto q34;
                }  
            }
            /////////////////////////////////////reject
           reject: return REJECTED;
           /////////////////////////////////////accept
           accept: return ALLOWED;
           
        }
    }
}