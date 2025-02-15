﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("ProjectMaster")]
    public partial class ProjectMaster
    {
        public ProjectMaster()
        {
            ProjectSites = new HashSet<ProjectSite>();
        }

        public int Id { get; set; }
        [Column("PONumber")]
        public string Ponumber { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int ProjectTypeId { get; set; }
        public int StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        public Guid? UpdatedBy { get; set; }

        [ForeignKey("ClientId")]
        [InverseProperty("ProjectMasters")]
        public virtual Clients Client { get; set; }
        [ForeignKey("ProjectTypeId")]
        [InverseProperty("ProjectMasters")]
        public virtual ProjectType ProjectType { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("ProjectMasters")]
        public virtual Status Status { get; set; }
        [InverseProperty("Po")]
        public virtual ICollection<ProjectSite> ProjectSites { get; set; }
    }
}