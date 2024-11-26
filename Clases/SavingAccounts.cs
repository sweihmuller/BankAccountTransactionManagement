using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTransactionManagement.Clases
{
    internal class SavingAccounts
    {
        private int accountNumber;
        private double balance;
        private List<String> depositHistory;
        private List<String> withdrawalHistory;

        public SavingAccounts(int accountNumber, double balance, List<string> depositHistory, List<string> withdrawalHistory)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.depositHistory = depositHistory;
            this.withdrawalHistory = withdrawalHistory;
        }

        public int AccountNumber { get { return accountNumber; } }
        public double Balance { get { return balance; } }
        public List<String> DepositHistory { get { return depositHistory; } }
        public List<String> WithdrawalHistory { get { return withdrawalHistory; } } 
    }
}
