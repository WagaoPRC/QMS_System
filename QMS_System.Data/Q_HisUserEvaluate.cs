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
    
    public partial class Q_HisUserEvaluate
    {
        public int Id { get; set; }
        public int HisDailyRequireDeId { get; set; }
        public int UserId { get; set; }
        public string Score { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Q_HisDailyRequire_De Q_HisDailyRequire_De { get; set; }
        public virtual Q_User Q_User { get; set; }
    }
}