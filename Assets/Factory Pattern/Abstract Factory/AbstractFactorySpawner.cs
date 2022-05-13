using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactorySpawner
{
    public static void SpawnAnimals()
    {
        AbstractFactory factory = FactoryProducer.GetFactory(FactoryType.AnimalFactory);

        IAnimal dog = factory.GetAnimal(AnimalType.Dog);
        IAnimal cat = factory.GetAnimal(AnimalType.Cat);
        IAnimal snake = factory.GetAnimal(AnimalType.Snake);

        dog.Sound();
        cat.Sound();
        snake.Sound();
    }

    public static void SpawnBuildings()
    {
        AbstractFactory factory = FactoryProducer.GetFactory(FactoryType.BuildingFactory);

        IBUilding house = factory.GetBuilding(BuildingType.House);
        IBUilding apartment = factory.GetBuilding(BuildingType.Apartment);
        IBUilding fireStation = factory.GetBuilding(BuildingType.FireStation);

        house.Name();
        apartment.Name();
        fireStation.Name();
    }
}
