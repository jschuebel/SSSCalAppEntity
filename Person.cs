using System;
using System.Collections.Generic;
   
namespace SSSCalApp.Core.Entity
{
    [Serializable]
    public class Person
    {
      public Person()
        {
            //this.Events = new HashSet<Event>();
        }

        public Person Copy(Event inEvt)
        {
            var per = UtilityTools.DeepClone<Person>(this);

            if (inEvt!=null && inEvt.Date!=null)
              per.DateOfBirth=inEvt.Date.Value;

            return per;
        }

    
      public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HomePhone { get; set; }
        public string Work { get; set; }
        public string Pager { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
        public int AddressId { get; set; }
        public bool BirthdayAlert { get; set; }
        public DateTime Createdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
