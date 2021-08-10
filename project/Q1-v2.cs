// using System;
// using System.Collections.Generic;

// namespace project
// {
//     internal class Q1
//     {
//         public Q1()
//         {
//         }

//         internal string process1(string input)
//         {
//             string ALLOWED = "ALLOWED";
//             string REJECTED = "REJECTED";
//             Stack<char> tempstack = new Stack<char>();
//             Stack<char> totalstack = new Stack<char>();
//             var size = input.Length;
//             input = input.ToLower();
//             if (size == 0)
//                 return ALLOWED;
//             var firstChar = input[0];
//             int counter = 0;
//             /////////////////////////////////////////////////////////////////state 1
//             ///start with a
//             if (firstChar == 'a')
//             {
//                 while (counter < size && input[counter] == 'a')
//                 {
//                     counter++;
//                     tempstack.Push('a');
//                     totalstack.Push('a');
//                 }
//                 if(counter>=size){
//                     return REJECTED;
//                 }
//                 ///continu with b
//                 if (counter<size &&input[counter] == 'b')
//                 {
//                     while (counter<size &&input[counter] == 'b' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('b');
//                     }
//                     if(counter>=size){
//                     return REJECTED;
//                 }
//                     if (tempstack.Count != 0 || input[counter] == 'b' || input[counter] == 'a')
//                     {
//                         return REJECTED;
//                     }
//                     ///ends in c
//                     while (counter < size && input[counter] == 'c')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0)
//                     {
//                         return REJECTED;
//                     }
//                 }
//                 ///continu with c
//                 else if (counter<size && input[counter] == 'c')
//                 {
//                     while (counter<size &&input[counter] == 'c' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('c');
//                     }
//                      if(counter>=size){
//                     return REJECTED;}
                
//                     if (tempstack.Count != 0 || input[counter] == 'c' || input[counter] == 'a')
//                     {
//                         return REJECTED;
//                     }
//                     //ends in b
//                     while (counter < size && input[counter] == 'b')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0)
//                     {
//                         return REJECTED;
//                     }
//                 }
              

//                 return ALLOWED;
//             }
//             ////////////////////////////////////////////////////////////////////state 2
//             ///start with b
//             else if (firstChar == 'b')
//             {
//                 while (counter < size && input[counter] == 'b')
//                 {
//                     counter++;
//                     tempstack.Push('b');
//                     totalstack.Push('b');
//                 }
//                 if(counter>=size){
//                     return REJECTED;
//                 }
//                 ///continu with a
//                 if (counter<size &&input[counter] == 'a')
//                 {
                    
//                     while (counter<size &&input[counter] == 'a' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('a');
//                     }
                    
//                     if(counter>=size){
//                     return REJECTED;
//                     }
//                     if (tempstack.Count != 0 || input[counter] == 'b' || input[counter] == 'a')
//                     {
//                         return REJECTED;
//                     }
//                     ///ends in c
//                     while (counter < size && input[counter] == 'c')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0)
//                     {
//                         return REJECTED;
//                     }
//                 }
//                 ///continu with c
//                 else if (counter<size &&input[counter] == 'c')
//                 {
//                     while (counter<size && input[counter] == 'c' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('c');
//                     }
//                     if(counter>=size){
//                     return REJECTED;}
//                     if (tempstack.Count != 0 || input[counter] == 'c' || input[counter] == 'b')
//                     {
//                         return REJECTED;
//                     }
//                     //ends in a
//                     while (counter < size && input[counter] == 'a')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0)
//                     {
//                         return REJECTED;
//                     }
//                 }

//                 return ALLOWED;
//             }
//             ////////////////////////////////////////////////////////////////////state 3
//             ///start with c
//             else if (firstChar == 'c')
//             {
//                 while (counter < size && input[counter] == 'c')
//                 {
//                     counter++;
//                     tempstack.Push('c');
//                     totalstack.Push('c');
//                 }
//                 if(counter>=size){
//                     return REJECTED;
//                 }
//                 ///continu with a
//                 if (counter<size &&input[counter] == 'a')
//                 {
//                     while (counter<size &&input[counter] == 'a' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('a');
//                     }
//                      if(counter>=size){
//                     return REJECTED;
//                 }
//                     if (tempstack.Count != 0 || input[counter] == 'c' || input[counter] == 'a')
//                     {
//                         return REJECTED;
//                     }
//                     ///ends in b
//                     while (counter < size && input[counter] == 'b')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0)
//                     {
//                         return REJECTED;
//                     }
//                 }
//                 ///continu with b
//                 else if (counter<size&&input[counter] == 'b')
//                 {
//                     while (counter<size && input[counter] == 'b' && tempstack.Count > 0)
//                     {
//                         tempstack.Pop();
//                         counter++;
//                         totalstack.Push('b');
//                     }
//                     if(counter>=size){
//                     return REJECTED;
//                 }
//                     if (tempstack.Count != 0 || input[counter] == 'c' || input[counter] == 'b')
//                     {
//                         return REJECTED;
//                     }
//                     //ends in a
//                     while (counter < size && input[counter] == 'a')
//                     {
//                         if (totalstack.Count == 0)
//                         {
//                             return REJECTED;
//                         }
//                         counter++;
//                         totalstack.Pop();

//                     }
//                     if (totalstack.Count != 0 ||tempstack.Count !=0)
//                     {
//                         return REJECTED;
//                     }
//                 }

//                 return ALLOWED;
                
//             }
//             return "invalid input";
//         }
//     }
// }