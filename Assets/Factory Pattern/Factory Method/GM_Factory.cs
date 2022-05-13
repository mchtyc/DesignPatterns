using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Factory : MonoBehaviour
{
    public NPCFactorySpawner spawner;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawner.SpawnWorkers();
        }
    }
}
