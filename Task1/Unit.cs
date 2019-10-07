using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    abstract class Unit
    {
       internal int XPos;
       internal int YPos;
       internal int Health;
       internal int Max_Health;
       internal int Speed;
       internal int Attack;
       internal int Attack_range;
       internal int Team;
       internal string Symbol;
       internal bool IsAttacking;
        internal string NameType;
       

        public abstract void Move( int drec);
        public abstract void Combat(Unit u);
        public abstract bool AtRange(Unit ran);        
        public abstract void DeathUnit();
        public abstract override string ToString();
        
    }
}
