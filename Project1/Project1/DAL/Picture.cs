//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        public int PicureID { get; set; }
        public string PictureFile { get; set; }
        public Nullable<int> Person_PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
