using AdvertApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvertApi.Services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);
        Task<bool> CheckHealthAsync();
        Task<AdvertModel> GetByIdAsync(string id);
        Task<List<AdvertModel>> GetAllAsync();
    }
}
