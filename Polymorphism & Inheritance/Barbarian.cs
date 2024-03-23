using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Swordsman
{
    public int atkNum;

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Barbarian class obtained. \nAttack is increased by " + atkNum + ".");
    }
}
