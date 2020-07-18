﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("RTA")]
    public partial class Rtum
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? SeqNo { get; set; }
        public string PoleTag { get; set; }
        [Column(TypeName = "text")]
        public string Coordinates { get; set; }
        [Column(TypeName = "text")]
        public string Location { get; set; }
        public bool? Nap { get; set; }
        public bool? Lcp { get; set; }
        public bool? Arm { get; set; }
        [Column(TypeName = "text")]
        public string Remarks { get; set; }
        public string PolePic { get; set; }
        public string PoleTagPic { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }

        [ForeignKey("SiteId")]
        [InverseProperty("Rta")]
        public virtual Site Site { get; set; }
    }
}