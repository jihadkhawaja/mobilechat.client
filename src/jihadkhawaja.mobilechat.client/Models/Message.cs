﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jihadkhawaja.mobilechat.client.Models
{
    public class Message : EntityBase
    {
        [Required]
        public Guid SenderId { get; set; }
        [Required]
        public Guid ChannelId { get; set; }
        [NotMapped]
        public string? DisplayName { get; set; }
        public bool Sent { get; set; }
        public DateTime? DateSent { get; set; }
        public bool Seen { get; set; }
        public DateTime? DateSeen { get; set; }
        [Required]
        public string? Content { get; set; }
    }
}
