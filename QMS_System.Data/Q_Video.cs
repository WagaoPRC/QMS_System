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
    
    public partial class Q_Video
    {
        public Q_Video()
        {
            this.Q_VideoTemplate_De = new HashSet<Q_VideoTemplate_De>();
        }
    
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FakeName { get; set; }
    
        public virtual ICollection<Q_VideoTemplate_De> Q_VideoTemplate_De { get; set; }
    }
}
