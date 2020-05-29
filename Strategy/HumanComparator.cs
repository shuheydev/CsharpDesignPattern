using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{

    //比較の対象を変えようと思ったら,
    //比較タイプみたいなパラメータを用意して
    //処理を分岐させることになる
    //つらい...
    class HumanComparator
    {
        private int type = -1;

        public static readonly int COMPARE_AGE = 1;
        public static readonly int COMPARE_HEIGHT = 2;
        public static readonly int COMPARE_WEIGHT = 3;

        public HumanComparator(int type)
        {
            this.type = type;
        }

        public int Compare(Human h1,Human h2)
        {
            if(this.type==COMPARE_AGE)
            {
                //年齢の比較
                if (h1.Age > h2.Age)
                {
                    return 1;
                }
                else if (h1.Age == h2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else if(this.type==COMPARE_HEIGHT)
            {
                //身長の比較
                return -1;
            }
            else if(this.type==COMPARE_WEIGHT)
            {
                //体重の比較
                return -1;
            }
            else
            {
                //その他
                return -1;
            }
        }
    }
}
