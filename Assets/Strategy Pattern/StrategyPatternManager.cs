using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyPatternManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Character boby = ScriptableObject.CreateInstance<Boby>();
            Character jane = ScriptableObject.CreateInstance<Jane>();
            Character jack = ScriptableObject.CreateInstance<Jack>();

            boby.FireWeapon();
            jane.FireWeapon();
            jack.FireWeapon();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Character boby = ScriptableObject.CreateInstance<Boby>();
            IWeapon MG = new MachineGun();
            boby.SetWeapon(MG);
            boby.FireWeapon();
        }
    }
}
