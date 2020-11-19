//****************************************************************
// Programmer: Melinda Fischer
// CIT Number : CIT245143
// Date: 19 November 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assessment 4 - Task 2 - Binary Tree - Class Node
// Refrences: class notes, stack overflow, dotnetperl, csharpexamples, youtube
//**************************************************************** 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelindaFischerAssessment4
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int? Data { get; set; }
        public Node Parent {get; set;}

       //Node Constructors
       public Node()
        {
            Parent = null;
            LeftNode = null;
            RightNode = null;
            Data = null;

        }
      
    }
   

}
