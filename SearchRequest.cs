using System;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.AspNetCore.Mvc;

namespace SSSCalApp.Core.Entity
{
 //  [ModelBinder(typeof(SearchBinder))]
    public class SearchRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public FilterObjectWrapper FilterObjectWrapper { get; set; }
        public ICollection<SortObject> SortObjects { get; set; }
    }
}