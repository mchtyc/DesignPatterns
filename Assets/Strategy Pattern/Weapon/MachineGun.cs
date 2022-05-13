using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : IWeapon
{
    public void Use()
    {
        Debug.Log("Machine Gun firing.");
    }
}
