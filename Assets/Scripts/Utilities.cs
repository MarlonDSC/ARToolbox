using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class Utilities
{
    public static T ImportJson<T>(TextAsset asset)
    {
        string jsonPath = (asset.text);
        // string jsonStr = File.ReadAllText(jsonPath);
        return JsonConvert.DeserializeObject<T>(asset.text);
        // return JsonUtility.FromJson<T>(asset.text);
        // return JsonConvert.DeserializeObject<T>(jsonStr);
    }
}