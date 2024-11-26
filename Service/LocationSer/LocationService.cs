using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service.LocationSer
{
    public class LocationService: ILocationService
    {
        private readonly HttpClient _httpClient;

        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetProvinceName(string provinceCode)
        {
            // Ví dụ: OpenStreetMap Nominatim API
            var response = await _httpClient.GetAsync($"https://nominatim.openstreetmap.org/details.php?osmtype=R&osmid={provinceCode}&format=json");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<dynamic>();
            return result["display_name"]?.ToString() ?? "Unknown";
        }

        public async Task<string> GetDistrictName(string districtCode)
        {
            // Gọi tương tự như GetProvinceName
            var response = await _httpClient.GetAsync($"https://nominatim.openstreetmap.org/details.php?osmtype=R&osmid={districtCode}&format=json");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<dynamic>();
            return result["display_name"]?.ToString() ?? "Unknown";
        }

        public async Task<string> GetWardName(string wardCode)
        {
            // Gọi tương tự như GetProvinceName
            var response = await _httpClient.GetAsync($"https://nominatim.openstreetmap.org/details.php?osmtype=R&osmid={wardCode}&format=json");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<dynamic>();
            return result["display_name"]?.ToString() ?? "Unknown";
        }
    }
}
