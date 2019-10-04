using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    abstract class Building
    {
        protected int bPosX;
        protected int bPosY;
        protected int bHealth;
        protected int bHealthMax;
        protected int bFaction;
        protected string bSym;

        public abstract void DieDie();
        public abstract void BuildingString();
    }
}
