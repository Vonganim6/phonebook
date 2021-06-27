using System;
using Microsoft.EntityFrameworkCore;
using PhonebookManager.Model;
namespace PhonebookManager.Data
{
    public class PhonebookDBContext : DbContext
    {
        public PhonebookDBContext() : base() { }
        public new virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<PhoneBook> PhoneBooks  { get; set; }

    }
}
