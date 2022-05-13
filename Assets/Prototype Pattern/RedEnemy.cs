using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : Enemy
{
    void Awake()
    {
        Name = "Red Enemy";
    }

    public void Shoot()
    {
        Debug.Log("Shooting");
    }
}
