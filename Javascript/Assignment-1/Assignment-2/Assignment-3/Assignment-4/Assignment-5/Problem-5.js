class Employee
{
    constructor(name, salary)
    {
        this.name = name;
        this.salary = salary;
    }

    getDetails()
    {
        console.log(`Employee Name: ${this.name}`);
        console.log(`Employee Salary: ${this.salary}`);
    }
}
class Manager extends Employee
{
    constructor(name, salary, bonus)
    {
        super(name, salary);
        this.bonus = bonus;
    }
    getTotalSalary()
    {
        return this.salary + this.bonus;
    }
}
class Director extends Manager
{
    constructor(name, salary, bonus, stockOptions)
    {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation()
    {
         return this.salary + this.bonus + this.stockOptions;
    }
}

let d1 = new Director("Henry", 70000, 40000, 20000);

d1.getDetails();
console.log("Total Salary (Manager Level): ", d1.getTotalSalary());
console.log("Full Compensation (Director Level): ", d1.getFullCompensation());