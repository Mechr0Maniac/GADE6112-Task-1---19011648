using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    class ResourceBuilding : Building
    {
        public bool IsDead { get; set; }
        public int PosX
        {
            get { return bPosX; }
            set { bPosX = value; }
        }
        public int PosY
        {
            get { return bPosY; }
            set { bPosY = value; }
        }
        public int Health
        {
            get { return bHealth; }
            set { bHealth = value; }
        }
        public int MaxHealth
        {
            get { return bHealthMax; }
        }
        public int Faction
        {
            get { return bFaction; }
        }
        public string Symbol
        {
            get { return bSym; }
            set { bSym = value; }
        }
        private int resourceType;

        public int ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }
        private int numResource;

        public int NumResource
        {
            get { return numResource; }
            set { numResource = value; }
        }
        private int numResourcePR;

        public int NumResourcePR
        {
            get { return numResourcePR; }
            set { numResourcePR = value; }
        }
        private int pool;

        public int Pool
        {
            get { return pool; }
            set { pool = value; }
        }



        public override void DieDie()
        {
            Symbol = "XX";
            IsDead = true;
        }
        public override void BuildingString()
        {
            throw new NotImplementedException();
        }
    }
}
