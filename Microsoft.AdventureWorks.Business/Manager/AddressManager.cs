using Microsoft.AdventureWorks.Data.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AdventureWorks.Data.Data;
using System.Linq.Expressions;

namespace Microsoft.AdventureWorks.Business.Manager
{
    public class AddressManager:IAddressManager
    {
        private readonly IAddressRepository addressRepository;
        public AddressManager(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public void Add(Address entity)
        {
            this.addressRepository.Add(entity);
        }

        public void Delete(Address entity)
        {
            this.addressRepository.Delete(entity);
        }

        public void Edit(Address entity)
        {
            this.addressRepository.Edit(entity);
        }

        public IQueryable<Address> FindBy(Expression<Func<Address, bool>> predicate)
        {
            return this.addressRepository.FindBy(predicate);
        }

        public IQueryable<Address> GetAll()
        {
            return this.addressRepository.GetAll();
        }

        public void Save()
        {
            this.addressRepository.Save();
        }
    }
}
