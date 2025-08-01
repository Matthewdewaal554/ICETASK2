using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexIceTask
{


   public class Games
    {
        int price, year;
        string name, genre;
        public Games(int price, int year, string name, string genre)
        {
            this.price = price;
            this.year = year;
            this.name = name;
            this.genre = genre;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return price;
                else if (index == 1)
                    return year;
                else if (index == 2)
                    return name;
                else if (index == 3)
                    return genre;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    price = (int)value;
                else if (index == 1)
                    year = (int)value;
                else if (index == 2)
                    name = (string)value;
                else if (index == 3)
                    genre = (string)value;
            }
        }
            public object this[string index]
        {
            get
            {
                if (index == "price")
                    return price;
                else if (index == "year")
                    return year;
                else if (index == "name")
                    return name;
                else if (index == "genre")
                    return genre;
                else
                    return null;
            }
            set
            {
                if (index == "price")
                    price = (int)value;
                else if (index == "year")
                    year = (int)value;
                else if (index == "name")
                    name = (string)value;
                else if (index == "genre")
                    genre = (string)value;
            }

        }
    } 
}
 
