using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ResourceBuilding : Building
    {
        internal int resourcetype;
        internal int ReasourceGenerated;
        internal int ReasourcePoolRemaining;
        internal int ResourcesPerRound;


        public int xpos
        {
            get { return base.XPos; }
            set { XPos = value; }
        }
        public int ypos
        {
            get { return base.YPos; }
            set { YPos = value; }
        }
        public int health
        {
            get { return base.Health; }
            set { Health = value; }
        }
        private int maxhealth;

        public int Maxhealth
        {
            get { return base.Max_Health; }
        }
        private int team;

        public int tEaM
        {
            get { return base.Team; }
            set { Team = value; }
        }
        private string symbol;

        public string sYmbol
        {
            get { return base.Symbol; }
            set { Symbol = value; }
        }
        

       


        public override void Death()
        {
            if (Health == 0)
            {
                symbol = "X";
            }
        }
        public  override string ToString()
        {

            string temp = "";
            temp += "Building symbol:";
            temp += " " + Symbol + "}";
            temp += "building postion" + XPos + "," + YPos + ".the building health;";
            temp += Health;            
            return temp;
        }
        public bool IsDestroyed { get; set; }

        //public override void Death()
        //{
        //    if (Health == 0)
        //    {
        //        symbol = "X";
        //    }
        //}

        public ResourceBuilding(int bX, int bY, int bh, int bf, string bs)
        {
            xpos = bX;
            ypos = bY;
            health = bh;
            base.Max_Health = bh;
            base.Team = bf;
            sYmbol = bs;
        }

    }
}
