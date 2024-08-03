using Microsoft.Extensions.Hosting;

namespace ClinicAPI.Dtos
{
    public class SaveImage
    {
        public async Task<string> HandleImage(IFormFile Image)
        {
            
            if (Image != null && Image.Length > 0)
            {
                // Get the path to save the image
                string uploadDir = Path.Combine("Images");
                string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

                string fileName = Guid.NewGuid().ToString() + timeStamp + "-" + Image.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                // Save the image to the server
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(fileStream);
                }


                return "/images/" + fileName;



            }
            return null;
        }
    }
    
}
