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
    
    public partial class Q_ReadTemplate
    {
        public Q_ReadTemplate()
        {
            this.Q_ReadTemp_Detail = new HashSet<Q_ReadTemp_Detail>();
            this.Q_UserCommandReadSound = new HashSet<Q_UserCommandReadSound>();
        }
    
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Q_Language Q_Language { get; set; }
        public virtual ICollection<Q_ReadTemp_Detail> Q_ReadTemp_Detail { get; set; }
        public virtual ICollection<Q_UserCommandReadSound> Q_UserCommandReadSound { get; set; }
    }
}