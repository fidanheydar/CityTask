using System;
using System.Collections.Generic;
using System.Text;

namespace CityTask
{
    internal class ChinaCity : City
    {
        public override int Population
        {
            get
            {
                return _population;
            }
             set
            {
                if (value >= 100000)
                {
                    _population = value;
                }
            }
        }

    }
}
