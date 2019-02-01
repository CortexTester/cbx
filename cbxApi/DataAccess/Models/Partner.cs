using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace cbxApi.DataAccess.Models
{
    public class Partner
    {
        public long InviterId { get; set; }
        [ForeignKey(nameof(InviterId))]
        public Party Inviter {get;set;}

        public long AccepterId { get; set; }
        [ForeignKey(nameof(AccepterId))]
        public Party Accepter { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}