using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Building
    {
        protected int XPos;
        protected int YPos;
        protected int Health;
        protected int Max_Health;      
        protected int Team;
        protected string Symbol;
        
        
        public abstract void Death();
        public abstract override string ToString();
    }
}
