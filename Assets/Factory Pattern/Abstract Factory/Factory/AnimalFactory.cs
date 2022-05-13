using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFactory : AbstractFactory
{
    public override IAnimal GetAnimal(AnimalType type)
    {
        IAnimal animal;

        switch (type)
        {
            case AnimalType.Cat:
                animal = new Cat();
                return animal;
            case AnimalType.Dog:
                animal = new Dog();
                return animal;
            case AnimalType.Snake:
                animal = new Snake();
                return animal;
        }

        return null;
    }

    public override IBUilding GetBuilding(BuildingType type)
    {
        return null;
    }
}
