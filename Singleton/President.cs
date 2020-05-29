using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   sealed class President
    {
        private static President _instance;

        private President()
        {
            //コンストラクタを隠す
        }

        public static President GetInstance()
        {
            if(_instance is null)
            {
                _instance = new President();
            }

            return _instance;
        }
    }
}
