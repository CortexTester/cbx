using System;

namespace cbxApi.DataAccess.Models
{
    public class Attribute
    {
        public long Id { get; set; }
        public User Creater { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Content { get; set; }
        public Party Party{ get; set; }
    }
}