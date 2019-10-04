using System;
using System.Windows.Forms;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    class GameEngine
    {
        Map map;
        private int round;
        Random r = new Random();
        GroupBox grpMap;

        public int Round
        {
            get { return round; }
        }

        public GameEngine(int numUnits, TextBox txtInfo, GroupBox gMap)
        {
            grpMap = gMap;
            map = new Map(numUnits, txtInfo);
            map.Generate();
            map.Display(grpMap);
            round = 1;
        }

        public void Update()
        {
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)map.Units[i];
                    if (mu.Health <= mu.MaxHealth * 0.25)
                    {
                        mu.PosMov(r.Next(0, 4));
                    }
                    else
                    {
                        (Unit closest, int distanceTo) = mu.CloseNme(map.Units);
                        if (distanceTo <= mu.Range)
                        {
                            mu.IsAttacking = true;
                            mu.Attack(closest);
                        }
                        else
                        {
                            if (closest is MeleeUnit)
                            {
                                MeleeUnit closestMu = (MeleeUnit)closest;
                                if (mu.PosX > closestMu.PosX)
                                {
                                    mu.PosMov(0);
                                }
                                else if (mu.PosY < closestMu.PosY)
                                {
                                    mu.PosMov(1);
                                }
                                else if (mu.PosX < closestMu.PosX)
                                {
                                    mu.PosMov(2);
                                }
                                else if (mu.PosY > closestMu.PosY)
                                {
                                    mu.PosMov(3);
                                }
                            }
                            else if (closest is RangedUnit)
                            {
                                RangedUnit closestRu = (RangedUnit)closest;
                                if (mu.PosX > closestRu.PosX)
                                {
                                    mu.PosMov(0);
                                }
                                else if (mu.PosY < closestRu.PosY)
                                {
                                    mu.PosMov(1);
                                }
                                else if (mu.PosX < closestRu.PosX)
                                {
                                    mu.PosMov(2);
                                }
                                else if (mu.PosY > closestRu.PosY)
                                {
                                    mu.PosMov(3);
                                }
                            }
                        }

                    }
                }
                else if (map.Units[i] is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)map.Units[i];
                    (Unit closest, int distanceTo) = ru.CloseNme(map.Units);
                    if (distanceTo <= ru.Range)
                    {
                        ru.IsAttacking = true;
                        ru.Attack(closest);
                    }
                    else
                    {
                        if (closest is MeleeUnit)
                        {
                            MeleeUnit closestMu = (MeleeUnit)closest;
                            if (ru.PosX > closestMu.PosX)
                            {
                                ru.PosMov(0);
                            }
                            else if (ru.PosY < closestMu.PosY)
                            {
                                ru.PosMov(1);
                            }
                            else if (ru.PosX < closestMu.PosX)
                            {
                                ru.PosMov(2);
                            }
                            else if (ru.PosY > closestMu.PosY)
                            {
                                ru.PosMov(3);
                            }
                        }
                        else if (closest is RangedUnit)
                        {
                            RangedUnit closestRu = (RangedUnit)closest;
                            if (ru.PosX > closestRu.PosX)
                            {
                                ru.PosMov(0);
                            }
                            else if (ru.PosY < closestRu.PosY)
                            {
                                ru.PosMov(1);
                            }
                            else if (ru.PosX < closestRu.PosX)
                            {
                                ru.PosMov(2);
                            }
                            else if (ru.PosY > closestRu.PosY)
                            {
                                ru.PosMov(3);
                            }
                        }
                    }
                }
            }
            map.Display(grpMap);
            round++;
        }

        public int DistanceTo(Unit a, Unit b)
        {
            int distance = 0;

            if (a is MeleeUnit && b is MeleeUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.PosX - end.PosX) + Math.Abs(start.PosY - end.PosY);
            }
            else if (a is RangedUnit && b is MeleeUnit)
            {
                RangedUnit start = (RangedUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.PosX - end.PosX) + Math.Abs(start.PosY - end.PosY);
            }
            else if (a is RangedUnit && b is RangedUnit)
            {
                RangedUnit start = (RangedUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.PosX - end.PosX) + Math.Abs(start.PosY - end.PosY);
            }
            else if (a is MeleeUnit && b is RangedUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.PosX - end.PosX) + Math.Abs(start.PosY - end.PosY);
            }
            return distance;
        }
    }
}
