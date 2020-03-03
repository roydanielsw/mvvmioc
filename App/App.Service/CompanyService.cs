using App.Models; 
using System.Collections.Generic;
using System.Linq; 
using System.IO;

namespace App.Services
{
    /// <summary>
    /// This class returns merged list of Companies
    /// </summary>
    public class CompanyService : ICompanyService
    {
        public List<Company> GetCompanyList()
        {
            List<Company> companyList = new List<Company>();
            companyList.Add(new Company()
            {
                ContactEmail = "test@gmail.com",
                ContactName = "test name",
                ContactPhoneNumber = "xxx-xxx-xxxx"
            });
            companyList.Add(new Company()
            {
                ContactEmail = "test1@gmail.com",
                ContactName = "test name1",
                ContactPhoneNumber = "xxx-xxx-xxxx"
            });

            return companyList;
        }
    }
}
