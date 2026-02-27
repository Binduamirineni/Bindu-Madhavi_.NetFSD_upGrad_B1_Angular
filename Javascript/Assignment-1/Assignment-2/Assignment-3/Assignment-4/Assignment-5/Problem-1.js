class Person
{
    constructor(name, age)
    {
        this.name = name;
        this.age = age;
    }

    greet()
    {
        return "Hello, my name is "+" "+this.name+ " and I am "+this.age+" "+"years old.";
    }
}

let p1 = new Person("Henry", 25);
console.log(p1.greet());