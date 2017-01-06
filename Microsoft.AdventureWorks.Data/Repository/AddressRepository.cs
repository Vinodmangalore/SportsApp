using Microsoft.AdventureWorks.Data.Services;
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using Microsoft.AdventureWorks.Data.Data;

namespace Microsoft.AdventureWorks.Data.Repository
{
    public class AddressRepository : Repository<Entities, Address>, IAddressRepository
    {
        
    }
}
