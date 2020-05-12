using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.ContractModels;
using Services;
using static Data.Entities.Enums;

namespace Tests
{
    [TestClass]
    public class ContractServicesTests
    {
        [TestMethod]
        public void SuccessRateTest_ShouldProduceCorrectSuccessRate()
        {
            SuccessRateModel entity = new SuccessRateModel();
            ContractListItem itemOne = new ContractListItem() { ContractStatus = ContractStatus.Completed };
            ContractListItem itemTwo = new ContractListItem() { ContractStatus = ContractStatus.Completed };
            ContractListItem itemThree = new ContractListItem() { ContractStatus = ContractStatus.Failed };
            ContractListItem itemFour = new ContractListItem() { ContractStatus = ContractStatus.Failed };
            List<ContractListItem> listOfContracts = new List<ContractListItem>() { itemOne, itemTwo, itemThree, itemFour };
            double completedContracts = 0;
            double failedContracts = 0;
            for (int i = 0; i < listOfContracts.Count(); i++)
            {
                var nextContract = listOfContracts[i];
                if (nextContract.ContractStatus == ContractStatus.Completed)
                    completedContracts++;
                else if (nextContract.ContractStatus == ContractStatus.Failed)
                    failedContracts++;
            }
            double finalizedContracts = completedContracts + failedContracts;
            int successRate = Convert.ToInt32((completedContracts / finalizedContracts) * 100);
            entity.SuccessRate = $"{successRate}%";

            Console.WriteLine(entity.SuccessRate);

            Assert.AreEqual("50%", entity.SuccessRate);

        }
    }
}
