using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType
{
    Boss, Secretary, Seller
}

public class NPCFactory : MonoBehaviour
{
    public INPC getNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Boss:
                return new Boss();

            case NPCType.Secretary:
                return new Secretary();

            case NPCType.Seller:
                return new Seller();
        }
        return null;
    }
}
