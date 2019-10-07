using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task1
{
    [Serializable]
    class Map
    {
        int PosX;
        int PosY;

        Random rm = new Random();
        List<Unit> units = new List<Unit>();
        int unNumbers;
        int buildNum;
        TextBox Mapinfotxt = new TextBox();
        List<Building> buildings;
        private int bull;

        

        public List<Unit> Units

        {
            get { return units; }
            set { units = value; }
        }

        public List<Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }

        public void Generate()
        {
            for (int i = 0; i < unNumbers; i++)
            {
                if (rm.Next(0, 2) == 0) //Generate Melee Unit
                {
                    MeleeUnit m = new MeleeUnit(rm.Next(0, 20),
                                                rm.Next(0, 20),
                                                100,
                                                1,
                                                20,
                                                (i % 2 == 0 ? 1 : 0),
                                                "M",
                                                "Knight");
                    units.Add(m);
                }
                else // Generate Ranged Unit
                {
                    RangeUnit ru = new RangeUnit(rm.Next(0, 20),
                                                rm.Next(0, 20),
                                                100,
                                                1,
                                                20,
                                                5,
                                                (i % 2 == 0 ? 1 : 0),
                                                "R",
                                                "Wizard");
                    units.Add(ru);
                    //for(j= 0;j< numBuildings;j++)
                }
            }
            for (int j = 0; j < buildNum; j++)
            {
                if (rm.Next(0, 2) == 0)
                {
                    ResourceBuilding a = new ResourceBuilding(rm.Next(0, 20),
                                                              rm.Next(0, 20),
                                                              500,
                                                              (j % 2 == 0 ? 1 : 0),
                                                              "[RS]");
                    buildings.Add(a);
                }
                else
                {
                    FactoryBuilding f = new FactoryBuilding(rm.Next(0, 20),
                                                              rm.Next(0, 20),
                                                              500,
                                                              (j % 2 == 0 ? 1 : 0),
                                                              "[FS]");
                    buildings.Add(f);
                }
            }
        }

       

        //public void Populate(GroupBox groupBox1)
        //{
        //    //groupBox1.Controls.Clear();
        //    //foreach (MeleeUnit me in meeleun)
        //    //{
        //    //    Label lblmel = new Label();
        //    //    lblmel.Width = 20;
        //    //    lblmel.Height = 20;
        //    //    lblmel.Location = new System.Drawing.Point(me.XPos * 20, me.YPos * 20);
        //    //    lblmel.Text = me.Symbol;

        //    //    groupBox1.Controls.Add(lblmel);
        //    //}
        //    //foreach (RangeUnit ran in rangeu)
        //    //{
        //    //    Label lblrang = new Label();
        //    //    lblrang.Width = 20;
        //    //    lblrang.Height = 20;
        //    //    lblrang.Location = new System.Drawing.Point(ran.XPos * 20, ran.YPos * 20);
        //    //    lblrang.Text = ran.Symbol;

        //    //    groupBox1.Controls.Add(lblrang);
        //    //}
        //}
        public void Display(GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            foreach (Unit u in units)
            {
                Button b = new Button();
                if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    b.Size = new Size(20, 20);
                    b.Location = new Point(mu.XPos * 20, mu.YPos * 20);
                    b.Text = mu.Symbol;
                    if (mu.team == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }
                    b.Click += Unit_Click;
                    groupBox.Controls.Add(b);
                }
                else
                {
                    RangeUnit ru = (RangeUnit)u;
                    b.Size = new Size(20, 20);
                    b.Location = new Point(ru.XPos * 20, ru.YPos * 20);
                    b.Text = ru.Symbol;

                }
                b.Click += Unit_Click;
                groupBox.Controls.Add(b);
            }
            foreach (Building d in buildings)
            {
                Button bb = new Button();
                if (d is ResourceBuilding)
                {
                    ResourceBuilding Ab = (ResourceBuilding)d;
                    bb.Size = new Size(40, 40);
                    bb.Location = new Point(Ab.xpos * 20, Ab.ypos * 20);
                    bb.Text = Ab.sYmbol;
                    if (Ab.tEaM == 0)
                    {
                        bb.ForeColor = Color.AliceBlue;
                    }
                    else
                    {
                        bb.ForeColor = Color.AntiqueWhite;
                    }
                   
                    bb.Click += Unit_Click;
                    groupBox.Controls.Add(bb);
                }
                else
                {
                    FactoryBuilding FB = (FactoryBuilding)d;
                    bb.Size = new Size(40, 40);
                    bb.Location = new Point(FB.xpos * 20, FB.ypos * 20);
                    bb.Text = FB.sYmbol;
                    if (FB.tEaM == 0)
                    {
                        bb.ForeColor = Color.Purple;
                    }
                    else
                    {
                        bb.ForeColor = Color.Pink;
                    }
                        bb.Click += Building_Click;
                    groupBox.Controls.Add(bb);
                }

            }

        }


        public void Unit_Click(object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (Unit u in units)
            {
                if (u is RangeUnit)
                {
                    RangeUnit ru = (RangeUnit)u;
                    if (ru.XPos == x && ru.YPos == y)
                    {
                        Mapinfotxt.Text = "";
                        Mapinfotxt.Text = ru.ToString();
                    }
                }
                else if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    if (mu.XPos == x && mu.YPos == y)
                    {
                        Mapinfotxt.Text = "";
                        Mapinfotxt.Text = mu.ToString();
                    }
                }
            }
        }

        public void Building_Click(object sender, EventArgs e)
        {
            int x, y;
            Button bb = (Button)sender;
            x = bb.Location.X / 20;
            y = bb.Location.Y / 20;

            foreach (Building d in buildings)
            {
                if (d is ResourceBuilding)
                {
                    ResourceBuilding rB = (ResourceBuilding)d;
                    if (rB.xpos == x && rB.ypos == y)
                    {
                        Mapinfotxt.Text = "";
                        Mapinfotxt.Text = rB.ToString();
                    }
                }
                else if (d is FactoryBuilding)
                {
                    FactoryBuilding fB = (FactoryBuilding)d;
                    if (fB.xpos == x && fB.ypos == y)
                    {
                        Mapinfotxt.Text = "";
                        Mapinfotxt.Text = fB.ToString();
                    }
                }
            }

        }
        public void SetSize(int X, int Y)
        {
             PosX = X;
             PosY = Y;

        }
        //public void Update()
        //{
        //}
        public Map(int n, int bn, TextBox txt) // to create units.
        {

            units = new List<Unit>();
            unNumbers = n;
            Mapinfotxt = txt;
            buildNum = bn;
        }
    }
}

