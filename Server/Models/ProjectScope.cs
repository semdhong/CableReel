﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("ProjectScope")]
    public partial class ProjectScope
    {
        public ProjectScope()
        {
            ProjectScopeProgresses = new HashSet<ProjectScopeProgress>();
        }

        public int Id { get; set; }
        [Column("POSiteId")]
        public int? PositeId { get; set; }
        public int? ScopeId { get; set; }
        public int? UomId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? EstQtyLength { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ActQtyLength { get; set; }

        [ForeignKey("PositeId")]
        [InverseProperty("ProjectScopes")]
        public virtual ProjectSite Posite { get; set; }
        [ForeignKey("ScopeId")]
        [InverseProperty("ProjectScopes")]
        public virtual Scope Scope { get; set; }
        [ForeignKey("UomId")]
        [InverseProperty("ProjectScopes")]
        public virtual Uom Uom { get; set; }
        [InverseProperty("ProjectScope")]
        public virtual ICollection<ProjectScopeProgress> ProjectScopeProgresses { get; set; }
    }
}