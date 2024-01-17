using System;
using System.Collections.Generic;
using System.Text;

namespace CityTask
{
    internal class City
    {
        private string _name;
        protected int _population;
        public string Name { get { return _name; } 

            set {
                if (value != null && value.Length >= 3 && value.Length <= 20 && CheckName(value))
                {
                    _name = value;
                }
            }
        }

        public virtual int Population
        {
            get
            {
                return _population;
            }
            set
            {
                if (value >= 0)
                {
                    _population = value;
                }
            }
        }


        private bool CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }



    }
}
