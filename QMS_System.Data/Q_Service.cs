//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QMS_System.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Q_Service
    {
        public Q_Service()
        {
            this.Q_DailyRequire = new HashSet<Q_DailyRequire>();
            this.Q_HisDailyRequire = new HashSet<Q_HisDailyRequire>();
            this.Q_ServiceShift = new HashSet<Q_ServiceShift>();
            this.Q_ServiceStep = new HashSet<Q_ServiceStep>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public System.DateTime TimeProcess { get; set; }
        public string Note { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Q_DailyRequire> Q_DailyRequire { get; set; }
        public virtual ICollection<Q_HisDailyRequire> Q_HisDailyRequire { get; set; }
        public virtual ICollection<Q_ServiceShift> Q_ServiceShift { get; set; }
        public virtual ICollection<Q_ServiceStep> Q_ServiceStep { get; set; }
    }
}