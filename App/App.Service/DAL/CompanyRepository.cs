using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using App.Models;

namespace App.Services.DAL
{
    public class CompanyRepository : ICompanyRepository, IDisposable
    {
        private ApplicationDbContext context;

        public CompanyRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Company> GetCompanyList()
        {
           return context.Companies.ToList<Company>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context?.Dispose();
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