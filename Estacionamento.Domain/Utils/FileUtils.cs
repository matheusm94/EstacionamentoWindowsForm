using System.Text.Json;

namespace Estacionamento.Domain.Utils
{
    public interface IFileUtils
    {
        void SaveFile<T>(IEnumerable<T> file, string fileName);
        List<T> ReadFile<T>(string fileName);
    }
    public class FileUtils : IFileUtils
    {
        public void SaveFile<T>(IEnumerable<T> file, string fileName)
        {

            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dataDirectory = Path.Combine(rootDirectory, "data");

            string filePath = dataDirectory + "/" + fileName;

            if (!File.Exists(filePath))
                Directory.CreateDirectory(dataDirectory);

            string jsonString = JsonSerializer.Serialize(file);
            File.WriteAllText(filePath, jsonString);
        }

        public List<T> ReadFile<T>(string fileName)
        {
            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dataDirectory = Path.Combine(rootDirectory, "data");

            string filePath = dataDirectory + "/" + fileName;

            List<T> data = new List<T>();

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                data = JsonSerializer.Deserialize<List<T>>(jsonData);
            }

            return data;
        }
    }
}
