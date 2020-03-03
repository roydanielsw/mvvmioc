using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.DAL
{
    interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanyList();
    } 
}
