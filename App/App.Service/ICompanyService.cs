using App.Models; 
using System.Collections.Generic;
 

namespace App.Services
{
    /// <summary>
    /// Interface ICompanyService
    /// </summary>
    public interface ICompanyService
    {
        List<Company> GetCompanyList();
    }
}
