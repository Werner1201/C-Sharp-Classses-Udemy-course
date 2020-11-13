using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercicio.Services
{
    class PaypalService : IOnlinePaymentService
    {

        public PaypalService()
        {

        }

        public double PaymentFee(double amount)
        {
            double fee = amount + amount * 0.02;
            return fee;
        }

        public double Interest(double amount, int months)
        {
            double interest = amount + amount * 0.01 * months;
            return interest;
        }
    }
}
