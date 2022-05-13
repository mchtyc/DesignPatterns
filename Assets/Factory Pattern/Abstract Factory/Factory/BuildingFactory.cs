using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingFactory : AbstractFactory
{
    public override IAnimal GetAnimal(AnimalType type)
    {
        return null;
    }

    public override IBUilding GetBuilding(BuildingType type)
    {
        IBUilding building;

        switch (type)
        {
            case BuildingType.House:
                building = new House();
                return building;
            case BuildingType.Apartment:
                building = new Apartment();
                return building;
            case BuildingType.FireStation:
                building = new FireStation();
                return building;
        }

        return null;
    }
}
