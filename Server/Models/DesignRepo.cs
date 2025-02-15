﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("DesignRepo")]
    public partial class DesignRepo
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Location { get; set; }
        public int? Revision { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }

        [ForeignKey("SiteId")]
        [InverseProperty("DesignRepos")]
        public virtual Site Site { get; set; }
    }
}