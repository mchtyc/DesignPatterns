using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : ScriptableObject
{
    protected IWeapon weapon;

    public void FireWeapon()
    {
        weapon.Use();
    }

    public void SetWeapon(IWeapon weaponType)
    {
        Debug.Log("Weapon changed!");
        this.weapon = weaponType;
    }
}
