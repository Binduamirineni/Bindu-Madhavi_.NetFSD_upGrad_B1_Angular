class Vehicle
{
    constructor(brand, speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    start()
    {
        console.log(`The car brand is ${this.brand} and the speed will be ${this.speed}`); 
    }
}

class Car extends Vehicle
{
    constructor(brand, speed, fuelType)
    {
        super(brand, speed); 
        this.fuelType = fuelType;
    }

    showDetails()
    {
        super.start();
        console.log(`Fuel Type: ${this.fuelType}`);
    }
}

let car1 = new Car("Benz", 240,"Petrol");
car1.showDetails();