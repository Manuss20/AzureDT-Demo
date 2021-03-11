using System.Collections.Generic;
using System.Threading.Tasks;
using SupplyChain.Web.Models;

namespace SupplyChain.Web.Services.Interfaces
{
  public interface ITsiDataGeneratorService
  {
    List<Dictionary<string, Dictionary<string, TsiDataPoint>>> GenerateData();
  }
}