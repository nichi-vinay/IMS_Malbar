//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JMS.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryAudit
    {
        public int Id { get; set; }
        public System.DateTime AuditDate { get; set; }
        public int ItemsInShelves { get; set; }
        public int ItemsInInventory { get; set; }
        public int VarianceItems { get; set; }
        public int VarianceItemsInShelves { get; set; }
        public int VarianceItemsInInventory { get; set; }
        public string VarianceItemsIdsJson { get; set; }
    }
}
