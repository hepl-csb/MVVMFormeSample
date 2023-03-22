using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVMSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.ViewModel.Tests
{
    [TestClass()]
    public class MainWindowViewModelTests
    {
        [TestMethod()]
        public void MainWindowViewModelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddPersonneTest()
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();
            viewModel.AddPersonne(null);
            Assert.AreEqual(4, viewModel.Items.Count);
            Assert.AreSame(viewModel.Items[0], viewModel.SelectedPersonne);
        }
    }
}