using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using cbxApi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace cbxApi.DataAccess.Models
{
    public class Party
    {
        private PartyContext context;

        public Party() { }
        private Party(PartyContext partyContext)
        {
            context = partyContext;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Attribute => context.Set<Attribute>()
            .AsQueryable().Where(a => EF.Property<int>(a, "PartyId") == Id)
            .OrderByDescending(p => p.CreatedTime).Single().Content;

        public ICollection<User> Users { get; set; }

        public ICollection<Partner> Partners { get; set; }

        public ICollection<Attribute> AttributeHistory { get; set; }

        // public int? ParentId { get; set; }
        // [ForeignKey(nameof(ParentId))]
        // public Party Parent {get; set;}

    }
}