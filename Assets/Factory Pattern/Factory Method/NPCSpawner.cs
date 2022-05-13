using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactorySpawner : MonoBehaviour
{
    public NPCFactory factory;

    INPC boss, secretary, seller;

    public void SpawnWorkers()
    {
        boss = factory.getNPC(NPCType.Boss);
        secretary = factory.getNPC(NPCType.Secretary);
        seller = factory.getNPC(NPCType.Seller);

        boss.Speak();
        secretary.Speak();
        seller.Speak();
    }
   
}
