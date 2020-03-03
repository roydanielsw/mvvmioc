using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using App.Models;

namespace App.Services.DAL
{
    public class CompanyRepository : IDisposable
    { 

        public CompanyRepository()
        {
             
        }

        public IEnumerable<Company> GetCompanyList()
        {
            using (var context = new ApplicationDbContext())
            {
                var customer = context.Companies.ToList<Company>();
                return customer;
            }
        }
          

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
             
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}