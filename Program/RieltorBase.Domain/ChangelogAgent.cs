//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RieltorBase.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChangelogAgent
    {
        public int ChangelogAgentId { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string AgentWhoChanges { get; set; }
        public string AgentInfo { get; set; }
    }
}
