class Payment
{
    pay(amount)
    {
        console.log("Processing payment of", amount);
    }
}
class CreditCardPayment extends Payment
{
    pay(amount)
    {
        console.log(`Paid ${amount} using CreditCardPayment..!`);
    }
}
class UPIPayment extends Payment
{
    pay(amount)
    {
        console.log(`Paid ${amount} using UPIPayment..!`);
    }
}
class CashPayment extends Payment
{
    pay(amount)
    {
        console.log(`Paid ${amount} using CashPayment..!`);
    }
}

let payments = [new CreditCardPayment(), new UPIPayment(), new CashPayment()];

payments.forEach(p => p.pay(500));