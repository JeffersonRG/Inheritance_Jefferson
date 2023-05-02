using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Jefferson
{
    class FPS : Game
    {

        //calling upon them from a different class after adding estbParam and titleParam.
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        //replaces the abstract string and gives it a return that will be called later.
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
