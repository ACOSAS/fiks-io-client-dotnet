using System;
using System.Threading.Tasks;
using KS.Fiks.IO.Client.Models;

namespace KS.Fiks.IO.Client.Catalog
{
    public interface ICatalogHandler
    {
        Task<Account> Lookup(LookupRequest request);

        Task<string> GetPublicKey(Guid receiverAccountId);
    }
}