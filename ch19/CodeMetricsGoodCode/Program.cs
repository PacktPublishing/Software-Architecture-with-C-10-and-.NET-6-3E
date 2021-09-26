using CodeMetricsGoodCode.Enums;
using System;
using System.Collections.Generic;

namespace CodeMetricsGoodCode
{
    class Program
    {
        delegate void CheckResultMethod(BillingMode billingMode, CreditCardProcessingResult messageResponse);
        static void Main()
        {
            var billingMode = GetBillingMode();
            var messageResponse = ProcessCreditCardMethod();
            var methodsForCheckingResult = GetMethodsForCheckingResult();
            if (methodsForCheckingResult.ContainsKey(messageResponse))
                methodsForCheckingResult[messageResponse](billingMode, messageResponse);
            else
                Console.WriteLine("The result of processing is unknown");
            
        }

      
        private static Dictionary<CreditCardProcessingResult, CheckResultMethod> GetMethodsForCheckingResult()
        {
            var methods = new Dictionary<CreditCardProcessingResult, CheckResultMethod>();
            methods.Add(CreditCardProcessingResult.ResultA, CheckResultA);
            methods.Add(CreditCardProcessingResult.ResultB, CheckResultB);
            methods.Add(CreditCardProcessingResult.ResultC, CheckResultC);
            methods.Add(CreditCardProcessingResult.ResultD, CheckResultD);
            methods.Add(CreditCardProcessingResult.ResultE, CheckResultE);
            methods.Add(CreditCardProcessingResult.ResultF, CheckResultF);
            methods.Add(CreditCardProcessingResult.ResultG, CheckResultG);
            methods.Add(CreditCardProcessingResult.Succeed, CheckResultSucceed);
            return methods;
        }

        private static void CheckResultSucceed(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode08)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultG(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode07)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultF(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode06)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultE(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode05)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultD(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode04)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultC(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode03)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultB(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode02)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        private static void CheckResultA(BillingMode billingMode, CreditCardProcessingResult messageResponse)
        {
            if (billingMode == BillingMode.Mode01)
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
            else
                Console.WriteLine($"Billing Mode {billingMode} for Message Response {messageResponse}");
        }

        /// <summary>
        /// This is just an example about how to answer the "billing mode" 
        /// </summary>
        /// <returns>A result for simulating the billing mode</returns>
        private static BillingMode GetBillingMode()
        {
            return BillingMode.Mode01;
        }

        /// <summary>
        /// This is just an example about how to answer the "credit card processing" 
        /// </summary>
        /// <returns>A result for simulating the processing method</returns>
        private static CreditCardProcessingResult ProcessCreditCardMethod()
        {
            return CreditCardProcessingResult.Succeed;
        }
    }
}
