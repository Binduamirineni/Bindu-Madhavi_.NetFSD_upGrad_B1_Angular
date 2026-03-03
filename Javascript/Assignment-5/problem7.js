class Animal
{
    makeSound()
    {
        console.log("Animal make sound");  
    }
}

class Dog extends Animal
{
    makeSound()
    {
        console.log("Dog is barking Bow Bow");
    }
}

class Cat extends Animal
{
    makeSound()
    {
        console.log("Cat is saying Meow Meow");
    }
}

class Cow extends Animal
{
    makeSound()
    {
        console.log("Cow is saying Moo Moo");  
    }
}


let animals = [new Dog(), new Cat(), new Cow()];
animals.forEach(a => a.makeSound());