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
    
    public partial class Q_EquipTypeProcess
    {
        public int Id { get; set; }
        public int EquipTypeId { get; set; }
        public int ProcessId { get; set; }
        public int Step { get; set; }
        public int Priority { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Q_EquipmentType Q_EquipmentType { get; set; }
        public virtual Q_Process Q_Process { get; set; }
    }
}