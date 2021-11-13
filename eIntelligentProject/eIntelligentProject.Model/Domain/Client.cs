using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eIntelligentProject.Model.Domain
{
    public class Client
    {
        #region Required

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(9)]
        public string DNI { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surnames { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public string CountryResidence { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        #endregion

        #region Optional

        public string CompanyName { get; set; }

        public string TwitterAccount { get; set; }

        public ICollection<Interest> Interests { get; set; }

        public int Genre { get; set; }

        #endregion
    }
}
