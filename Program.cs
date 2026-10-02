Animal[] animals = new Animal[]
    {
    new Dog("Rex"),
    new Cat("Whiskers"),
    new Dog("Spot"),
    new Cat("Luna"),
    };

foreach (Animal animal in animals)
{
    animal.MakeSound();
}   