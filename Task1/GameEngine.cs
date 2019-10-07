using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class GameEngine
    {
        GroupBox grpMap;
        Random rm = new Random();
        private int NumRounds;      
        Map map;

        public int numRounds
        {
            get { return NumRounds; }
        }
        public GameEngine(int numUnits,int buildNum, TextBox Mapinfotxt, GroupBox gMap)
        {
            grpMap = gMap;
            map = new Map(numUnits, buildNum, Mapinfotxt);
            map.Generate();
            map.Display(grpMap);

            NumRounds = 1;
        }

        public void GameLogic()
        {
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)map.Units[i];
                    if (mu.Health <= mu.max_hp * 0.25) // Running Away
                    {
                        mu.Move(rm.Next(0, 4));
                    }
                    else
                    {
                        int shortest = 100;
                        Unit closestM = mu;
                        foreach (Unit u in map.Units)
                        {
                            if (u is MeleeUnit)
                            {
                                MeleeUnit otherMu = (MeleeUnit)u;
                                int distance = Math.Abs(mu.XPos - otherMu.XPos)
                                    + Math.Abs(mu.YPos - otherMu.YPos);
                                if (distance < shortest)
                                {
                                    shortest = distance;
                                    closestM = otherMu;
                                }
                            }
                        }

                        //Check In Range
                        int distanceTo = 0;
                        if (distanceTo <= mu.attackrage)
                        {
                            mu.IsAttacking = true;
                            mu.Combat(closestM);
                        }
                        else //Move Towards
                        {
                            if (closestM is MeleeUnit)
                            {
                                MeleeUnit closestMu = (MeleeUnit)closestM;
                                if (mu.XPos > closestMu.XPos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.XPos < closestMu.XPos) //South
                                {
                                    mu.Move(2);
                                }
                                else if (mu.YPos > closestMu.YPos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.YPos < closestMu.YPos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                            else if (closestM is RangeUnit)
                            {
                                RangeUnit closestMMu = (RangeUnit)closestM;
                                if (mu.XPos > closestMMu.XPos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.XPos < closestMMu.XPos) //South
                                {
                                    mu.Move(2);
                                }
                                else if (mu.YPos > closestMMu.YPos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.YPos < closestMMu.YPos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                        }

                    }
                }
            }
            map.Display(grpMap);
            NumRounds++;
        }
        

        public int DistanceTo(Unit a, Unit b)
        {
            int distance = 0;

            if (a is MeleeUnit && b is MeleeUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangeUnit && b is MeleeUnit)
            {
                RangeUnit start = (RangeUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangeUnit && b is RangeUnit)
            {
                RangeUnit start = (RangeUnit)a;
                RangeUnit end = (RangeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is MeleeUnit && b is RangeUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                RangeUnit end = (RangeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            return distance;
        }

        public void Update()
        {

        }

    }

}
