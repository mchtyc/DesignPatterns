using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jack : Character
{
    void Awake()
    {
        this.weapon = new MachineGun();
    }
}
