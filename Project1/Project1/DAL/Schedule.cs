//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.Activities = new HashSet<Activity>();
            this.Labs = new HashSet<Lab>();
            this.StudyGroups = new HashSet<StudyGroup>();
        }
    
        public int ShedID { get; set; }
        public System.DateTime Date { get; set; }
        public string Day { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
        public virtual ICollection<StudyGroup> StudyGroups { get; set; }
    }
}
