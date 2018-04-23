using System.Data.Entity;

namespace DataAnnotationAttributes.Model {
    public class ContactContext: DbContext {
        public DbSet<Contact> Contacts { get; set; }
    }
}
