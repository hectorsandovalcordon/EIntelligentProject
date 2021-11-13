using System.ComponentModel.DataAnnotations;

namespace eIntelligentProject.Model.Domain
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }
        public string Sports { get; set; }
        public string Literature { get; set; }
        public string Cinema { get; set; }
        public string Games { get; set; }
        public string Education { get; set; }
    }
}
