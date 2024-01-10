using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserCode { get; set; }
        public string? Password { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? Status { get; set; }
        public Guid? TicketId { get; set; }
        public Guid? RecoverPasswordId { get; set; }
        public int? CentralTeamId { get; set; }
        public bool? IsCentralTeam { get; set; }
        public string? DeviceToken { get; set; }
        public byte? PlatformType { get; set; }
        public bool? NotificationEnabled { get; set; }
        public bool? IsNeewEventExist { get; set; }
        public string? LanguageCode { get; set; }
    }
}
