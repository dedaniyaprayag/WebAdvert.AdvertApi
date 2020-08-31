using AdvertApi.Models;
using System.Threading.Tasks;

namespace AdvertApi.Services
{
    interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task<bool> Confirm(ConfirmAdvertModel model);
    }

    public class DynamoDBAdvertStorage : IAdvertStorageService
    {
        public Task<string> Add(AdvertModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Confirm(ConfirmAdvertModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
