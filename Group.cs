using System;
using System.Collections.Generic;
    
namespace SSSCalApp.Core.Entity
{
    public partial class Group
    {
        public int Id { get; set; }
        public Nullable<int> EventId { get; set; }
        public Nullable<int> PersonId { get; set; }
    
        public virtual Person People { get; set; }
        public virtual Event Event { get; set; }
    }
}