using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public string name;
    public int baseAtk;

    public virtual void Attack()
    {
        Debug.Log("Adventurer Selected. " + name + " is their name.\nBase attack is " + baseAtk);
    }
}
