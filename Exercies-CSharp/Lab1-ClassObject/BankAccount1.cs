
namespace Exercies4_CSharp
{

    public class BankAccount
    {
        private decimal balance;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void WithRaw(decimal amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }

        var cmdArgs = command.Split();

        var cmdType = cmdArgs[0];
            switch (cmdType)
        {
            case "Create":
            Create(cmdArgs, accounts);
            break;
            case "Deposit":
            Deposit(cmdArgs, accounts);
            break;
            case "Withdraw":
            Withdraw(cmdArgs, accounts);
            break;
            case"Print":
            Print(cmdArgs, accounts);
            break;
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount
                {
                    Id = id
                };
                accounts.Add(id, acc);
            }
        }
    }
}

