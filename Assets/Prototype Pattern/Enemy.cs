using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ICopyable
{
    public string Name { get; set; }

    public ICopyable Copy()
    {
        Debug.Log("New " + Name + " is created.");
        return Instantiate(this);
    }
}
