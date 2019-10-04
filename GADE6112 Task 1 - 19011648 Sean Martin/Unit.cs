using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    abstract class Unit
    {
        protected int pposX;
        protected int pposY;
        protected int phealth;
        protected int phealthMax;
        protected int pspeed;
        protected int pattack;
        protected int pattackRange;
        protected int pfaction;
        protected string pchara;
        protected bool pisAttack;

        public abstract void PosMov(int direction);
        public abstract void Attack(Unit attack);
        public abstract bool IsInRange(Unit enemy);
        public abstract (Unit, int) CloseNme(List<Unit> units);
        public abstract void ShiNe();
        public abstract string UnitToString();
    }
}
