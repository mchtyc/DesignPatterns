using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : IWeapon
{
    public void Use()
    {
        Debug.Log("Pistol firing.");
    }
}
