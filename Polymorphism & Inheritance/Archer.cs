using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Adventurer
{
    public int range;

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Archer selected.\n" + "Range is " + range + ".");
    }
}
