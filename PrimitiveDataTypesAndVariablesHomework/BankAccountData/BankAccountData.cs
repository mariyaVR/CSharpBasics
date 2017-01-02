using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string holderFirstName;
            string holderMiddleName;
            string holderLastName;
            decimal balance;
            string bankName;
            string IBAN;
            long creditCardNumber1;
            long creditCardNumber2;
            long creditCardNumber3;

            holderFirstName = "Martin";
            holderMiddleName = "Plamenov";
            holderLastName = "Pavlov";
            balance = 500M;
            bankName = "DSK";
            IBAN = "BG80BNBG96611020345678";
            creditCardNumber1 = 8420974628956241;
            creditCardNumber2 = 4370254869201923;
            creditCardNumber3 = 9437012647382992;

            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, creditCardNumber1, creditCardNumber2, creditCardNumber3);
        }
    }
}
