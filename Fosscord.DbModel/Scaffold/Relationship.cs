﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Fosscord.DbModel.Scaffold
{
    [Table("relationships")]
    [Index("FromId", "ToId", Name = "IDX_a0b2ff0a598df0b0d055934a17", IsUnique = true)]
    public partial class Relationship
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = null!;
        [Column("from_id")]
        public string FromId { get; set; } = null!;
        [Column("to_id")]
        public string ToId { get; set; } = null!;
        [Column("nickname")]
        public string? Nickname { get; set; }
        [Column("type")]
        public int Type { get; set; }

        [ForeignKey("FromId")]
        [InverseProperty("RelationshipFroms")]
        public virtual User From { get; set; } = null!;
        [ForeignKey("ToId")]
        [InverseProperty("RelationshipTos")]
        public virtual User To { get; set; } = null!;
    }
}
