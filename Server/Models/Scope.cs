﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCableReel.Server.Models
{
    [Table("Scope")]
    public partial class Scope
    {
        public Scope()
        {
            ProjectScopes = new HashSet<ProjectScope>();
        }

        public int Id { get; set; }
        public string ScopeName { get; set; }

        [InverseProperty("Scope")]
        public virtual ICollection<ProjectScope> ProjectScopes { get; set; }
    }
}