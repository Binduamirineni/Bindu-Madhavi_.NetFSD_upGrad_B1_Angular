class BankAccount
{
    constructor(accounHolder, balance)
    {
        this.accounHolder = accounHolder;
        this.balance = balance;
    }

    deposit(amount)
    {
        if(amount > 0)
        {
            this.balance = this.balance + amount;
            console.log(`${amount} deposited succesfully`);
        }
        else
        {
            console.log("Invalid deposit amount.");
        }
    }

    withdraw(amount)
    {
        if(amount >0 && amount <= this.balance)
        {
            this.balance -= amount;
            console.log(`${amount} withdrawn successfully.`);   
        }else if(amount > this.balance)
        {
            console.log("Insufficient balance.");
        }
        else 
        {
            console.log("Invalid withdrawal amount.");
            
        }
    }

    checkBalance()
    {
        console.log(`Current balance: ₹${this.balance}`);
        return this.balance;
        
    }
}

let res = new BankAccount("Henry", 1000);
res.withdraw(300);
res.deposit(500);
res.checkBalance();