using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryProducer
{
    public static AbstractFactory GetFactory(FactoryType type)
    {
        switch (type)
        {
            case FactoryType.AnimalFactory:
                AbstractFactory animalFactory = new AnimalFactory();
                return animalFactory;
            case FactoryType.BuildingFactory:
                AbstractFactory buildingFactory = new BuildingFactory();
                return buildingFactory;
        }

        return null;    
    }
}
