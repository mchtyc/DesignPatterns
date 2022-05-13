using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public abstract IAnimal GetAnimal(AnimalType type);
    public abstract IBUilding GetBuilding(BuildingType type);
}
