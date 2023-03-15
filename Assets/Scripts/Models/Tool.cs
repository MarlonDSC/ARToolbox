using Newtonsoft.Json;

public class Tool
    {
        [JsonConstructor]
        public Tool(
            [JsonProperty("id")] int id,
            [JsonProperty("name")] string name,
            [JsonProperty("description")] string description,
            [JsonProperty("image")] string image
        )
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Image = image;
        }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("image")]
        public string Image { get; }
    }