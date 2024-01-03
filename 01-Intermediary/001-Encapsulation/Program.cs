
using Encapsulation.Models;

CheckingAccount account = new(1290314, 1000);

account.DisplayBalance();
account.Withdraw(500);
account.DisplayBalance();
account.Withdraw(5000);
account.DisplayBalance();
