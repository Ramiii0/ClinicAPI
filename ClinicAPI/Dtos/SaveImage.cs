using Microsoft.Extensions.Hosting;

namespace ClinicAPI.Dtos
{
    public class SaveImage
    {
        public static async Task<string> HandleImage(IFormFile Image,string rootpath)
        {
            
            if (Image != null && Image.Length > 0)
            {
                // Get the path to save the image
                string uploadDir = Path.Combine("Images/"+rootpath);
                string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

                string fileName = Guid.NewGuid().ToString() + timeStamp + "-" + Image.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                // Save the image to the server
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(fileStream);
                }


                return "Images/"+ rootpath+"/"+fileName;



            }
            return null;
        }
    }
    
}
