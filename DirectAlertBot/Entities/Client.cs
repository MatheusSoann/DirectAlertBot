﻿using System.ComponentModel.DataAnnotations;

namespace DirectAlertBot.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        public long UserId { get; set; }

        [MaxLength(64)]
        public string? FirstName { get; set; }

        [MaxLength(64)]
        public string? LastName { get; set; }

        [MaxLength(32)]
        public string? Username { get; set; }

        [MaxLength(12)]
        public string? LanguageCode { get; set; }
    }
}
