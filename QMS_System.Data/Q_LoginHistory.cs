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
    
    public partial class Q_LoginHistory
    {
        public int Id { get; set; }
        public int EquipCode { get; set; }
        public int UserId { get; set; }
        public System.DateTime Date { get; set; }
        public int StatusId { get; set; }
        public Nullable<System.DateTime> LogoutTime { get; set; }
    
        public virtual Q_Status Q_Status { get; set; }
        public virtual Q_User Q_User { get; set; }
    }
}