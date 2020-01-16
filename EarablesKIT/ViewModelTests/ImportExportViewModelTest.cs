using System;
using EarablesKIT.ViewModels;
using Xunit;

namespace ViewModelTests
{
    public class ImportExportViewModelTest
    {
        [Fact]
        public void Import()
        {
            var vm = new ImportExportViewModel();
            vm.ImportCommand.Execute(null);
        }
    }
}
