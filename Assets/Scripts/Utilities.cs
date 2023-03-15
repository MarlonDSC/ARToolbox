using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class Utilities
{
    public static T ImportJson<T>(string path)
    {
        string jsonPath = (Application.streamingAssetsPath + "/"+path);
        string jsonStr = File.ReadAllText(jsonPath);
        return JsonConvert.DeserializeObject<T>(jsonStr);
    }
}