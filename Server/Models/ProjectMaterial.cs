﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    public partial class ProjectMaterial
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string RefNo { get; set; }
        public int? MaterialId { get; set; }
        public int? UomId { get; set; }
        public int? EstQty { get; set; }
        public int? ActualQty { get; set; }
        public int? Variance { get; set; }
        public int? Used { get; set; }
        public int? ForReturn { get; set; }
        public Guid? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey("MaterialId")]
        [InverseProperty("ProjectMaterials")]
        public virtual Material Material { get; set; }
        [ForeignKey("SiteId")]
        [InverseProperty("ProjectMaterials")]
        public virtual ProjectSite Site { get; set; }
        [ForeignKey("UomId")]
        [InverseProperty("ProjectMaterials")]
        public virtual Uom Uom { get; set; }
    }
}