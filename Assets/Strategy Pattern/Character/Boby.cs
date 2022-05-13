using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boby : Character
{
    void Awake()
    {
        this.weapon = new Pistol();
    }
}
