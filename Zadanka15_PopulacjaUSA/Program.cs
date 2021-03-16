using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Zadanka15_PopulacjaUSA
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string response = client.DownloadString("https://datausa.io/api/data?drilldowns=Nation&measures=Population");
            response = response.Substring(response.IndexOf('['));
            response = response.Substring(0, response.IndexOf(']')+1);
            List<PopulationData> data = JsonSerializer.Deserialize<List<PopulationData>>(response);

            data.Sort(new YearComparer());
            data.ForEach(x => Console.WriteLine(x));

        }
    }
}
