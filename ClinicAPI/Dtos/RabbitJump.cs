using Newtonsoft.Json.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
namespace ClinicAPI.Dtos
{
    public class RabbitJump
    {
        public static string GetCpuId()
        {
            string cpuId = string.Empty;
            try
            {
                using (var managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor"))
                {
                    var managementObjects = managementObjectSearcher.Get();
                    foreach (ManagementObject obj in managementObjects)
                    {
                        cpuId = obj["ProcessorId"]?.ToString();
                        break; // There is usually only one processor, so we can break after getting the first one.
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving CPU ID: {ex.Message}");
            }

            return cpuId;
        }
        public static string ComputeSha512Hash(string rawData)
        {
            // Create a SHA512 instance
            using (SHA512 sha512Hash = SHA512.Create())
            {
                // Compute the hash
                byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }



        }
        public static string RetrieveFromAppSettings()
        {
            string key = "RabitJumpKey";
            // Specify the path to the appsettings.json file
            string appSettingsPath = "appsettings.json";

            // Read the existing JSON content
            var json = File.ReadAllText(appSettingsPath);

            // Parse the JSON content
            var jsonObj = JObject.Parse(json);

            // Get the current value for the specified key
            var currentValue = (string)jsonObj[key];

            // Check if the current value is valid and longer than 132 characters (4 + 128 characters)
            if (currentValue != null && currentValue.Length >= 132)
            {
                // Extract the 128-character string that was inserted after the 4th character
                return currentValue.Substring(27, 128);
            }
            else
            {
                // Handle the case where the string is not long enough
                return null;
            }
        }
    }
}
