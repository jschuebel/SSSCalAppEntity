using System;
using System.Collections.Generic;
using System.Linq;

namespace SSSCalApp.Core.Entity
{
    public class FilterObjectWrapper
    {
        public FilterObjectWrapper(string logic, ICollection<FilterObject> filterObjects)
        {
            Logic = logic;
            FilterObjects = filterObjects;
        }

        public string Logic { get; set; }
        public ICollection<FilterObject> FilterObjects { get; set; }
        public string LogicToken
        {
            get
            {
                switch (Logic)
                {
                    case "and":
                        return "&&";
                    case "or":
                        return "||";
                    default:
                        return null;
                }
            }
        }
    }

}