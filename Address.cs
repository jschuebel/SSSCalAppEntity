 using System;
 using System.Collections.Generic;
    
namespace SSSCalApp.Core.Entity
{
    public partial class Address
    {
        public Address()
        {
      //      this.Generals = new HashSet<Person>();
        }
    
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public System.DateTime createdate { get; set; }
    
  //      public virtual ICollection<Person> Generals { get; set; }
    }
}