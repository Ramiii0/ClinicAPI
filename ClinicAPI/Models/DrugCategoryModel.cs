namespace ClinicAPI.Models
{
    public class DrugCategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<DrugsModel> Drugs { get; set; }
        public DateTime DateCreated { get; set; }

        public DrugCategoryModel()
        {
            DateCreated = DateTime.Now; // Default value for DateCreated
        }
    }
}
