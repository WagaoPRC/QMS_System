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
    
    public partial class Q_Equipment
    {
        public Q_Equipment()
        {
            this.Q_MaindisplayDirection = new HashSet<Q_MaindisplayDirection>();
            this.Q_RegisterRecieveTicket = new HashSet<Q_RegisterRecieveTicket>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int EquipTypeId { get; set; }
        public int CounterId { get; set; }
        public int StatusId { get; set; }
        public string Position { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Q_Counter Q_Counter { get; set; }
        public virtual Q_EquipmentType Q_EquipmentType { get; set; }
        public virtual Q_Status Q_Status { get; set; }
        public virtual ICollection<Q_MaindisplayDirection> Q_MaindisplayDirection { get; set; }
        public virtual ICollection<Q_RegisterRecieveTicket> Q_RegisterRecieveTicket { get; set; }
    }
}