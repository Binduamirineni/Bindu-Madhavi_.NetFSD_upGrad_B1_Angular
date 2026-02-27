class Wallet
{
    #balance;

    constructor(balance = 0)
    {
        this.#balance = balance;
    }

    addMoney(amount)
    {
        if(amount > 0)
        {
            this.#balance += amount;
        }
    }

    spendMoney(amount) 
    {
        if (amount > 0 && amount <= this.#balance) {
            this.#balance -= amount;
        }
    }

    getBalance()
    {
        return this.#balance;
    }
}

const myWallet = new Wallet();
myWallet.addMoney(1000);
myWallet.spendMoney(750);

console.log(myWallet.getBalance());