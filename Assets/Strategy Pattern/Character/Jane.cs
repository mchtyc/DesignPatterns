using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jane : Character
{
    void Awake()
    {
        this.weapon = new AutomaticWeapon();
    }
}
