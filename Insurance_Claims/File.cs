//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance_Claims
{
    using System;
    using System.Collections.Generic;
    
    public partial class File
    {
        public int Id { get; set; }
        public System.Guid PublicId { get; set; }
        public string FileName { get; set; }
        public string BlobName { get; set; }
        public string Description { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedId { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeletedId { get; set; }
    }
}