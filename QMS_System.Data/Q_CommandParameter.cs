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
    
    public partial class Q_CommandParameter
    {
        public Q_CommandParameter()
        {
            this.Q_UserCmdRegister = new HashSet<Q_UserCmdRegister>();
        }
    
        public int Id { get; set; }
        public int CommandId { get; set; }
        public string Parameter { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Q_Command Q_Command { get; set; }
        public virtual ICollection<Q_UserCmdRegister> Q_UserCmdRegister { get; set; }
    }
}