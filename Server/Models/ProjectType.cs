﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("ProjectType")]
    public partial class ProjectType
    {
        public ProjectType()
        {
            ProjectMasters = new HashSet<ProjectMaster>();
        }

        public int Id { get; set; }
        [Column("ProjectType")]
        public string ProjectType1 { get; set; }

        [InverseProperty("ProjectType")]
        public virtual ICollection<ProjectMaster> ProjectMasters { get; set; }
    }
}