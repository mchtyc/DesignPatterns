using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactoryManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AbstractFactorySpawner.SpawnAnimals();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            AbstractFactorySpawner.SpawnBuildings();
        }
    }
}
