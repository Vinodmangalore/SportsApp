﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AdventureWorks.Data.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AWBuildVersion> AWBuildVersions { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual DbSet<JobCandidate> JobCandidates { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<CountryRegion> CountryRegions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual DbSet<Culture> Cultures { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Illustration> Illustrations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductDocument> ProductDocuments { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhotoes { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhotoes { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategories { get; set; }
        public virtual DbSet<ScrapReason> ScrapReasons { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasures { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
        public virtual DbSet<ProductVendor> ProductVendors { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual DbSet<ShipMethod> ShipMethods { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorAddress> VendorAddresses { get; set; }
        public virtual DbSet<VendorContact> VendorContacts { get; set; }
        public virtual DbSet<ContactCreditCard> ContactCreditCards { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public virtual DbSet<SalesReason> SalesReasons { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRates { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffers { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreContact> StoreContacts { get; set; }
        public virtual DbSet<vEmployee> vEmployees { get; set; }
        public virtual DbSet<vEmployeeDepartment> vEmployeeDepartments { get; set; }
        public virtual DbSet<vEmployeeDepartmentHistory> vEmployeeDepartmentHistories { get; set; }
        public virtual DbSet<vJobCandidate> vJobCandidates { get; set; }
        public virtual DbSet<vJobCandidateEducation> vJobCandidateEducations { get; set; }
        public virtual DbSet<vJobCandidateEmployment> vJobCandidateEmployments { get; set; }
        public virtual DbSet<vAdditionalContactInfo> vAdditionalContactInfoes { get; set; }
        public virtual DbSet<vStateProvinceCountryRegion> vStateProvinceCountryRegions { get; set; }
        public virtual DbSet<vProductAndDescription> vProductAndDescriptions { get; set; }
        public virtual DbSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions { get; set; }
        public virtual DbSet<vProductModelInstruction> vProductModelInstructions { get; set; }
        public virtual DbSet<vVendor> vVendors { get; set; }
        public virtual DbSet<vIndividualCustomer> vIndividualCustomers { get; set; }
        public virtual DbSet<vIndividualDemographic> vIndividualDemographics { get; set; }
        public virtual DbSet<vSalesPerson> vSalesPersons { get; set; }
        public virtual DbSet<vSalesPersonSalesByFiscalYear> vSalesPersonSalesByFiscalYears { get; set; }
        public virtual DbSet<vStoreWithDemographic> vStoreWithDemographics { get; set; }
    
        [DbFunction("Entities", "ufnGetContactInformation")]
        public virtual IQueryable<ufnGetContactInformation_Result> ufnGetContactInformation(Nullable<int> contactID)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufnGetContactInformation_Result>("[Entities].[ufnGetContactInformation](@ContactID)", contactIDParameter);
        }
    
        public virtual ObjectResult<uspGetBillOfMaterials_Result> uspGetBillOfMaterials(Nullable<int> startProductID, Nullable<System.DateTime> checkDate)
        {
            var startProductIDParameter = startProductID.HasValue ?
                new ObjectParameter("StartProductID", startProductID) :
                new ObjectParameter("StartProductID", typeof(int));
    
            var checkDateParameter = checkDate.HasValue ?
                new ObjectParameter("CheckDate", checkDate) :
                new ObjectParameter("CheckDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetBillOfMaterials_Result>("uspGetBillOfMaterials", startProductIDParameter, checkDateParameter);
        }
    
        public virtual ObjectResult<uspGetEmployeeManagers_Result> uspGetEmployeeManagers(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetEmployeeManagers_Result>("uspGetEmployeeManagers", employeeIDParameter);
        }
    
        public virtual ObjectResult<uspGetManagerEmployees_Result> uspGetManagerEmployees(Nullable<int> managerID)
        {
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetManagerEmployees_Result>("uspGetManagerEmployees", managerIDParameter);
        }
    
        public virtual ObjectResult<uspGetWhereUsedProductID_Result> uspGetWhereUsedProductID(Nullable<int> startProductID, Nullable<System.DateTime> checkDate)
        {
            var startProductIDParameter = startProductID.HasValue ?
                new ObjectParameter("StartProductID", startProductID) :
                new ObjectParameter("StartProductID", typeof(int));
    
            var checkDateParameter = checkDate.HasValue ?
                new ObjectParameter("CheckDate", checkDate) :
                new ObjectParameter("CheckDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetWhereUsedProductID_Result>("uspGetWhereUsedProductID", startProductIDParameter, checkDateParameter);
        }
    
        public virtual int uspLogError(ObjectParameter errorLogID)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspLogError", errorLogID);
        }
    
        public virtual int uspPrintError()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspPrintError");
        }
    
        public virtual int uspUpdateEmployeeHireInfo(Nullable<int> employeeID, string title, Nullable<System.DateTime> hireDate, Nullable<System.DateTime> rateChangeDate, Nullable<decimal> rate, Nullable<byte> payFrequency, Nullable<bool> currentFlag)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var rateChangeDateParameter = rateChangeDate.HasValue ?
                new ObjectParameter("RateChangeDate", rateChangeDate) :
                new ObjectParameter("RateChangeDate", typeof(System.DateTime));
    
            var rateParameter = rate.HasValue ?
                new ObjectParameter("Rate", rate) :
                new ObjectParameter("Rate", typeof(decimal));
    
            var payFrequencyParameter = payFrequency.HasValue ?
                new ObjectParameter("PayFrequency", payFrequency) :
                new ObjectParameter("PayFrequency", typeof(byte));
    
            var currentFlagParameter = currentFlag.HasValue ?
                new ObjectParameter("CurrentFlag", currentFlag) :
                new ObjectParameter("CurrentFlag", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateEmployeeHireInfo", employeeIDParameter, titleParameter, hireDateParameter, rateChangeDateParameter, rateParameter, payFrequencyParameter, currentFlagParameter);
        }
    
        public virtual int uspUpdateEmployeeLogin(Nullable<int> employeeID, Nullable<int> managerID, string loginID, string title, Nullable<System.DateTime> hireDate, Nullable<bool> currentFlag)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var currentFlagParameter = currentFlag.HasValue ?
                new ObjectParameter("CurrentFlag", currentFlag) :
                new ObjectParameter("CurrentFlag", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateEmployeeLogin", employeeIDParameter, managerIDParameter, loginIDParameter, titleParameter, hireDateParameter, currentFlagParameter);
        }
    
        public virtual int uspUpdateEmployeePersonalInfo(Nullable<int> employeeID, string nationalIDNumber, Nullable<System.DateTime> birthDate, string maritalStatus, string gender)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var nationalIDNumberParameter = nationalIDNumber != null ?
                new ObjectParameter("NationalIDNumber", nationalIDNumber) :
                new ObjectParameter("NationalIDNumber", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var maritalStatusParameter = maritalStatus != null ?
                new ObjectParameter("MaritalStatus", maritalStatus) :
                new ObjectParameter("MaritalStatus", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateEmployeePersonalInfo", employeeIDParameter, nationalIDNumberParameter, birthDateParameter, maritalStatusParameter, genderParameter);
        }
    }
}