using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProgram
{
    public class InventoryOperation
    {
        public void ReadJsonFile(string Filepath)
        {
            var data=File.ReadAllText(Filepath);
            var result=JsonConvert.DeserializeObject<List<InventaryData>>(data);
            foreach (var inventary in result)
            {
                Console.WriteLine(inventary.Name + "\t" + inventary.Weight + "\t" + inventary.PricePerkg + "\t" + inventary.Weight * inventary.pricePerkg);
            }
        }

    }
}
