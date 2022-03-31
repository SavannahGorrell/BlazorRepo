using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouthAndFamilyDB.Shared;

namespace YouthAndFamilyDB.Client.Services
{
    public interface ITeenService
    {
        event Action OnChange;
        List<HouseChurch> HouseChurches { get; set; }
        List<Teen> Teens { get; set; }
        Task<List<Teen>> GetTeens();
        Task GetHouseChurches();
        Task<Teen> GetTeen(int id);
        Task<List<Teen>> CreateTeen(Teen teen);
        Task<List<Teen>> UpdateTeen(Teen teen, int id);
        Task<List<Teen>> DeleteTeen(int id);
    }
}
