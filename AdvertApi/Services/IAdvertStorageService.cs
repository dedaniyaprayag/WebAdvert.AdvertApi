using AdvertApi.Models;
using System.Threading.Tasks;

namespace AdvertApi.Services
{
    interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);
    }
}
