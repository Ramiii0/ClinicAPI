namespace ClinicAPI.Models
{
    public class DrugsModel
    {
        public int Id { get; set; }
        public string DrugName { get; set; }
        public int DrugCategoryId { get; set; }
        public DrugCategoryModel DrugCategory { get; set; }
        public DateTime DateCreated { get; set; }

        public DrugsModel()
        {
            DateCreated = DateTime.Now; // Default value for DateCreated
        }


    }
}
