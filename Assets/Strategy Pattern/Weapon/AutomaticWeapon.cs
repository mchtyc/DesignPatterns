using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticWeapon : IWeapon
{
    public void Use()
    {
        Debug.Log("Automatic Weapon firing.");
    }
}
