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
    
    public partial class Q_User
    {
        public Q_User()
        {
            this.Q_DailyRequire_Detail = new HashSet<Q_DailyRequire_Detail>();
            this.Q_HisDailyRequire_De = new HashSet<Q_HisDailyRequire_De>();
            this.Q_HisUserEvaluate = new HashSet<Q_HisUserEvaluate>();
            this.Q_Login = new HashSet<Q_Login>();
            this.Q_LoginHistory = new HashSet<Q_LoginHistory>();
            this.Q_RegisterRecieveTicket = new HashSet<Q_RegisterRecieveTicket>();
            this.Q_UserCmdRegister = new HashSet<Q_UserCmdRegister>();
            this.Q_UserCommandReadSound = new HashSet<Q_UserCommandReadSound>();
            this.Q_UserEvaluate = new HashSet<Q_UserEvaluate>();
            this.Q_UserMajor = new HashSet<Q_UserMajor>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Help { get; set; }
        public string Professional { get; set; }
        public string Position { get; set; }
        public string WorkingHistory { get; set; }
        public string Counters { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Q_DailyRequire_Detail> Q_DailyRequire_Detail { get; set; }
        public virtual ICollection<Q_HisDailyRequire_De> Q_HisDailyRequire_De { get; set; }
        public virtual ICollection<Q_HisUserEvaluate> Q_HisUserEvaluate { get; set; }
        public virtual ICollection<Q_Login> Q_Login { get; set; }
        public virtual ICollection<Q_LoginHistory> Q_LoginHistory { get; set; }
        public virtual ICollection<Q_RegisterRecieveTicket> Q_RegisterRecieveTicket { get; set; }
        public virtual ICollection<Q_UserCmdRegister> Q_UserCmdRegister { get; set; }
        public virtual ICollection<Q_UserCommandReadSound> Q_UserCommandReadSound { get; set; }
        public virtual ICollection<Q_UserEvaluate> Q_UserEvaluate { get; set; }
        public virtual ICollection<Q_UserMajor> Q_UserMajor { get; set; }
    }
}