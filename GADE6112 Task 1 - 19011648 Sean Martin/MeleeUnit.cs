using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    class MeleeUnit : Unit
    {
        public bool IsDead { get; set; }
        public int PosX
        {
            get { return pposX; }
            set { pposX = value; }
        }
        public int PosY
        {
            get { return pposY; }
            set { pposY = value; }
        }
        public int Health
        {
            get { return phealth; }
            set { phealth = value; }
        }
        public int MaxHealth
        {
            get { return phealthMax; }
        }
        public int Speed
        {
            get { return pspeed; }
            set { pspeed = value; }
        }
        public int Damage
        {
            get { return pattack; }
            set { pattack = value; }
        }
        public int Range
        {
            get { return pattackRange; }
            set { pattackRange = value; }
        }
        public int Faction
        {
            get { return pfaction; }
        }
        public string Symbol
        {
            get { return pchara; }
            set { pchara = value; }
        }
        public bool IsAttacking
        {
            get { return pisAttack; }
            set { pisAttack = value; }
        }

        public MeleeUnit(int x, int y, int h, int d, int s, int f, string sy)
        {
            PosX = x;
            PosY = y;
            Health = h;
            phealthMax = h;
            Speed = s;
            Damage = d;
            Range = 1;
            pfaction = f;
            Symbol = sy;
            IsAttacking = false;
            IsDead = false;
        }

        public override void Attack(Unit attack)
        {
            if (attack is MeleeUnit)
                Health -= ((MeleeUnit)attack).Damage;
            else if (attack is RangedUnit)
            {
                Health -= (((RangedUnit)attack).Damage - ((RangedUnit)attack).Range);
            }
            if (Health <= 0)
            {
                ShiNe();
            }
        }
        public override (Unit,int) CloseNme(List<Unit> units)
        {
            int shortest = 100;
            Unit closest = this;                  
            foreach (Unit u in units)
            {
                if (u is MeleeUnit && u != this)
                {
                    MeleeUnit otherMu = (MeleeUnit)u;
                    int distance = Math.Abs(PosX - otherMu.PosX) + Math.Abs(PosY - otherMu.PosY);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherMu;
                    }
                }
                else if (u is RangedUnit && u != this)
                {
                    RangedUnit otherRu = (RangedUnit)u;
                    int distance = Math.Abs(PosX - otherRu.PosX) + Math.Abs(PosY - otherRu.PosY);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherRu;
                    }
                }

            }
            return (closest, shortest);
        }
        public override bool IsInRange(Unit enemy)
        {
            int distance;
            int enemyX = 0;
            int enemyY = 0;
            if (enemy is MeleeUnit)
            {
                enemyX = ((MeleeUnit)enemy).PosX;
                enemyY = ((MeleeUnit)enemy).PosY;
            }
            else if (enemy is RangedUnit)
            {
                enemyX = ((RangedUnit)enemy).PosX;
                enemyY = ((RangedUnit)enemy).PosY;
            }
            distance = Math.Abs(PosX - enemyX) + Math.Abs(PosY - enemyY);
            if (distance <= Range)
                return true;
            else
                return false;
        }
        public override void PosMov(int direction)
        {
            switch (direction)
            {
                case 0:
                    PosY--;
                    break;
                case 1:
                    PosX++;
                    break;
                case 2:
                    PosY++;
                    break;
                case 3:
                    PosX--;
                    break;
                default: break;
            }
        }
        public override void ShiNe()
        {
            Symbol = "X";
            IsDead = true;
        }
        public override string UnitToString()
        {
            string temp = "";
            temp += "Melee: ";
            temp += "{" + Symbol + "}";
            temp += "{" + PosX + "," + PosY + "}";
            temp += Health + ", " + Damage + ", " + Range + ", " + Speed;
            temp += (IsDead ? " DEAD!" : " ALIVE!");
            return temp;
        }
    }
}
