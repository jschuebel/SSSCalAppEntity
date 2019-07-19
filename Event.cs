using System;
using System.Collections.Generic;

namespace SSSCalApp.Core.Entity
{
    [Serializable]
    public partial class Event
    {
        public Event()
        {
 //           this.Groups = new HashSet<Group>();
        }
        public Event Copy(Person p)
        {
            var evt = UtilityTools.DeepClone<Event>(this);
            evt.UserName=p.Name;

            return evt;
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName {get; set;}
        public int TopicId { get; set; }
//        public string TopicDescription { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> RepeatYearly { get; set; }
        public Nullable<bool> RepeatMonthly { get; set; }
        public string Description { get; set; }
        public System.DateTime Createdate { get; set; }
        public string Topic { get; set; }
    
        public virtual Person CreateUser { get; set; }
        public virtual Topic topicf { get; set; }
 //       public virtual ICollection<Group> Groups { get; set; }
    }
}