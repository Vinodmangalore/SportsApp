using Microsoft.AdventureWorks.Data.Data;
using Microsoft.AdventureWorks.Data.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AdventureWorks.Business.Manager
{
    public interface IAddressManager
    {
        IQueryable<Address> GetAll();
        IQueryable<Address> FindBy(Expression<Func<Address, bool>> predicate);
        void Add(Address entity);
        void Delete(Address entity);
        void Edit(Address entity);
        void Save();

    }
}
