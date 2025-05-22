using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace Assignment_7._3._1;

public class QuantumRandomGenerator
{
    private static readonly HttpClient _client = new HttpClient();
    private static readonly IConfiguration _config;

    static QuantumRandomGenerator()
    {
        // Load configuration
        _config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("ANU__Key.json")
            .Build();
    }

    public static async Task<int[]> GetQuantumRandomNumbersAsync(int length, string type = "uint16", int? blockSize = null)
    {
        try
        {
            string apiKey = _config["ANU_Quantum_API:ApiKey"];
            string baseUrl = "https://api.quantumnumbers.anu.edu.au";
            
            // Build URL with parameters
            var query = $"?length={length}&type={type}";
            if (blockSize.HasValue && (type == "hex8" || type == "hex16"))
                query += $"&size={blockSize}";

            // Add API key to headers
            _client.DefaultRequestHeaders.Remove("x-api-key");
            _client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            
            var response = await _client.GetAsync($"{baseUrl}{query}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<QuantumResponse>(json);

            return result.Data ?? Array.Empty<int>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return Array.Empty<int>();
        }
    }

    // Model the API response
    private class QuantumResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public int[] Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}