using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : Enemy
{
    void Awake()
    {
        Name = "Blue Enemy";
    }

    public void Fly()
    {
        Debug.Log("Flying");
    }
}
