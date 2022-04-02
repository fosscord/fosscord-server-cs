﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Fosscord.DbModel.Scaffold
{
    [Table("read_states")]
    [Index("ChannelId", "UserId", Name = "IDX_0abf8b443321bd3cf7f81ee17a", IsUnique = true)]
    public partial class ReadState
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = null!;
        [Column("channel_id")]
        public string ChannelId { get; set; } = null!;
        [Column("user_id")]
        public string UserId { get; set; } = null!;
        [Column("last_message_id")]
        public string? LastMessageId { get; set; }
        [Column("last_pin_timestamp")]
        public DateTime? LastPinTimestamp { get; set; }
        [Column("mention_count")]
        public int? MentionCount { get; set; }
        [Column("manual")]
        public bool? Manual { get; set; }

        [ForeignKey("ChannelId")]
        [InverseProperty("ReadStates")]
        public virtual Channel Channel { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("ReadStates")]
        public virtual User User { get; set; } = null!;
    }
}
