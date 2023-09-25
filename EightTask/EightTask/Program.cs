using EightTask;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;


HttpClient client = new HttpClient();
string response = await client.GetStringAsync("https://restcountries.com/v3.1/all");
List<Country> country = JsonConvert.DeserializeObject<List<Country>>(response);
List<string> countries = new List<string>();
foreach (var item in country)
{
    var countryName = item.name.common;
    var path = countryName + ".txt";
    var region = item.region;
    var subRegion = item.subregion;
    var population = item.population;
    var area = item.area;
    var latlng = item.latlng;
    using (StreamWriter sr = new StreamWriter(path))
    {
        sr.WriteLine("Region:" + region);
        sr.WriteLine("Subregion: " + subRegion);
        sr.WriteLine("Population: " + population);
        sr.WriteLine("Area: " + area);
        sr.Write("latlng: ");
        foreach (var l in latlng)
        {
            sr.Write(l + " ");
        }
    }
}
