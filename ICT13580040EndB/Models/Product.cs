using System;
using SQLite;
namespace ICT13580040EndB.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Type { get; set; }

        [NotNull]
        public string Brand { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string Generation { get; set; }

        [NotNull]
        public string Date { get; set; }


        public int Mile { get; set; }

        [NotNull]
        public string Color { get; set; }

        [NotNull]
        public Boolean Deler { get; set; }

        [NotNull]
        public string Detail { get; set; }

        [NotNull]
        public string Price { get; set; }

        [NotNull]
        public string Country { get; set; }

        [NotNull]
        public string Phone { get; set; }

    }
}
