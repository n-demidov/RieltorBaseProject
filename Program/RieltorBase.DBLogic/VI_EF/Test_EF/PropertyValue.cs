//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VI_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyValue
    {
        public int RealtyObjectId { get; set; }
        public int PropertyTypeId { get; set; }
        public string StringValue { get; set; }
    
        public virtual PropertyType PropertyType { get; set; }
        public virtual RealtyObject RealtyObject { get; set; }
    }
}