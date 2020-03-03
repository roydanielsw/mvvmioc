using App.Models;
using App.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Wpf.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly ICompanyService _companyService;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ICompanyService companyService)
        {
            _companyService = companyService;
            List<Company> items = _companyService.GetCompanyList();
            CompanyList = new ObservableCollection<Company>(items);
        }

        private ObservableCollection<Company> _companyList;

        public ObservableCollection<Company> CompanyList
        {
            get { return _companyList; }
            set { Set(ref _companyList, value); }
        }

        private RelayCommand _loadCommand;

        public RelayCommand LoadCommand
        {
            get
            {
                if (_loadCommand == null)
                {
                    _loadCommand = new RelayCommand(() =>
                    {
                        List<Company> items = _companyService.GetCompanyList();
                        CompanyList = new ObservableCollection<Company>(items);
                    });
                }

                return _loadCommand;
            }
        }

    }
}