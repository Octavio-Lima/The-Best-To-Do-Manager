using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

public static class ListData 
{
    public static List<ListModel>? GetDataAsync(string listName) 
    {
        // Load the json file
        string filePath = @"C:\Users\octav\GitHub\The-Best-To-Do-Manager\Data\list.json";

        using (StreamReader r = new StreamReader(filePath))
        {
            string json = r.ReadToEnd();
            List<ListModel> list = JsonConvert.DeserializeObject<List<ListModel>>(json);

            if (list != null) 
            {
                return list;
            }
        }

        return null;
    }
}