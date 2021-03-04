using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4_1
{
    class Class1
    {
        public Class1() { }
            public Class1(string t,string[] S, string[] W, double h, double a, double b, double r)
            {
                type = t;
               typesStrongTo = S;
                typesWeakTo = W;
                health = h;
                attack = a;
                attackBuff = b;
                hitRate = r;
            }
        public double attackWithRatio(string enemyType)
        {
            //bool outcome = enemyType.Equals(typesWeakTo[0]);
            if (enemyType==typesWeakTo[0])
            {
                //Console.Write("若");
                return (attack * attackBuff)*0.5;
            }
            for (int i = 0; i < 6; ++i)
            { 
                //bool result = enemyType.Equals(typesStrongTo[i]);
                if (enemyType==typesStrongTo[i])
                {
                    //Console.Write("強");
                    return attack * 2 * attackBuff;
                }
            }
            
            return attack*attackBuff;
        }
        public string getType()
        {
            return type;
        }
        public double getHealth()
        {
            return health;
        }
        public void setHealth(double h)
        {
            health = h;
        }

        public string type;
        public string[] typesStrongTo=new string[6];
        public string[] typesWeakTo=new string[1];
        public double health;
        public double attack;
        public double attackBuff;
        public double hitRate;
    }
}
