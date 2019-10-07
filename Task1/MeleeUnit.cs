using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [Serializable]
    class MeleeUnit : Unit
    {
        public bool IsDead { get; set; }

        
        public int Xpos
        {
            get { return base.XPos; }
            set { XPos = value; }
        }
        public int Ypos
        {
            get { return base.YPos; }
            set { YPos = value; }
        }
        public int health
        {
            get { return base.Health; }
            set { Health = value; }
        }
        public int max_hp
        {
            get { return base.Max_Health; }
        }
        public int speed
        {
            get { return base.Speed;}
            set { Speed = value; }
        }
        public int attack
        {
            get { return base.Attack; }
            set { Attack = value; }
        }
        public int attackrage
        {
            get { return base.Attack_range; }
            set { Attack_range = value; }
        }
        public int team
        {
            get { return base.Team; }
            set { Team = value; }
        }
        public string symbol
        {
            get { return base.Symbol; }
            set { Symbol = value; }            
        }
        public bool isAttacking
        {
            get { return base.IsAttacking; }
            set { base.IsAttacking = value; }
        }
        public MeleeUnit(int x, int y, int mh, int s, int a, int t, string sy,string nt)
        {
            Xpos = x;
            Ypos = y;
            health = mh;
           base.Max_Health = mh;
            speed = s;
            attack = a;
            attackrage = 2;
            base.Team = t;
            Symbol = sy;
            IsAttacking = false;
            IsDead = false;
            //NameType = nt;
        }

       
            
        
        public override void Move(int drec)
        {
            switch (drec)
            {
                case 0: Ypos--; break; //north
                case 1: Xpos++; break; //east
                case 2: Xpos--; break; //south
                case 3: YPos++; break; //west
                default: break;
            }
        }
        public override void Combat(Unit Att)
        {
            if (Att is MeleeUnit)
            {
                health = health - ((MeleeUnit)Att).attack;
            }
            else if (Att is RangeUnit)
            {
                RangeUnit ru = (RangeUnit)Att;
                health = health - (ru.attack - ru.attackrage);
            }

            if (Health <= 0)
            {
                DeathUnit(); //DEATH !!!
            }
        }
       
        public override bool AtRange(Unit ran)
        {
            int distance = 0;
            int ranX = 0;
            int ranY = 0;
            if (ran is MeleeUnit)
            {
                ranX = ((MeleeUnit)ran).Xpos;
                ranY = ((MeleeUnit)ran).Ypos;
            }
            else if (ran is RangeUnit)
            {
                ranX = ((RangeUnit)ran).Xpos;
                ranY = ((RangeUnit)ran).Ypos;
            }
            distance = Math.Abs(XPos - ranX) + Math.Abs(YPos - ranY);
            if (distance <= Attack_range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void DeathUnit()
        {
            symbol = "X";
            IsDead = true;
        }

        public override string ToString()
        {
            string temp = "";
            temp += "Melee:";
            temp += "{" + symbol + "}";
            temp += "(" + Xpos + "," + Ypos + ")";
            temp += health + ", " + attack + ", " + Attack_range + ", " + Speed;
            temp += (IsDead ? " DEAD!" : " ALIVE!");
            temp += "Name Type:" + NameType;
            return temp;
        }

        
    }
}
