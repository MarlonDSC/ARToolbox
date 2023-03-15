using System.Collections.Generic;
using Newtonsoft.Json;

public class ToolResult
    {
        [JsonConstructor]
        public ToolResult(
            List<Tool> data
        )
        {
            this.Data = data;
        }

        [JsonProperty("data")]
        public IReadOnlyList<Tool> Data { get; }
    }