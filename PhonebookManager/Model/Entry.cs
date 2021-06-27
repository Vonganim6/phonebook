using System;
using System.ComponentModel.DataAnnotations;

namespace PhonebookManager.Model
{
    public class Entry
    {
        [Key]
        public int entryId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string  PhoneNumber { get; set; }
    }
}
