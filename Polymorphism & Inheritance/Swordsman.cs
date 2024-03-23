using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Adventurer
{
    public string weapon;

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Swordsman selected.\n" + weapon + " Equipped.");
    }
}
