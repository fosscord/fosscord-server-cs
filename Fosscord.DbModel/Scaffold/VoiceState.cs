﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Fosscord.DbModel.Scaffold
{
    [Table("voice_states")]
    public partial class VoiceState
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = null!;
        [Column("guild_id")]
        public string? GuildId { get; set; }
        [Column("channel_id")]
        public string? ChannelId { get; set; }
        [Column("user_id")]
        public string? UserId { get; set; }
        [Column("session_id")]
        public string SessionId { get; set; } = null!;
        [Column("token")]
        public string? Token { get; set; }
        [Column("deaf")]
        public bool Deaf { get; set; }
        [Column("mute")]
        public bool Mute { get; set; }
        [Column("self_deaf")]
        public bool SelfDeaf { get; set; }
        [Column("self_mute")]
        public bool SelfMute { get; set; }
        [Column("self_stream")]
        public bool? SelfStream { get; set; }
        [Column("self_video")]
        public bool SelfVideo { get; set; }
        [Column("suppress")]
        public bool Suppress { get; set; }
        [Column("request_to_speak_timestamp")]
        public DateTime? RequestToSpeakTimestamp { get; set; }

        [ForeignKey("ChannelId")]
        [InverseProperty("VoiceStates")]
        public virtual Channel? Channel { get; set; }
        [ForeignKey("GuildId")]
        [InverseProperty("VoiceStates")]
        public virtual Guild? Guild { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("VoiceStates")]
        public virtual User? User { get; set; }
    }
}
