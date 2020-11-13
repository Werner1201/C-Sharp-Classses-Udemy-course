using System;
using System.Collections.Generic;
using InterfacesExercicio.Entities;
using InterfacesExercicio.Services;

namespace InterfacesExercicio.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 0; i < months; i++)
            {
                double interest = _onlinePaymentService.Interest(contract.TotalValue / months, i+1);
                double payFee = _onlinePaymentService.PaymentFee(interest);


                contract.Installments.Add(new Installment(contract.Date.AddMonths(i + 1), payFee));
            }


        }
    }
}
