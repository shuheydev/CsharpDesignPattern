using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IWebPage
    {
        string GetContent();
    }

    class About : IWebPage
    {
        private readonly ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }
        public string GetContent()
        {
            return this.theme.GetColor();//Aboutのページ
        }
    }

    class Carrers : IWebPage
    {
        private readonly ITheme theme;

        public Carrers(ITheme theme)
        {
            this.theme = theme;
        }
        public string GetContent()
        {
            return this.theme.GetColor();//Careersのページ        }
        }
    }
}
