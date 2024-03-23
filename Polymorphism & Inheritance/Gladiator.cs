using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Swordsman
{
    public int defNum;

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Gladiator class obtained. \nDefense is increased by " + defNum + ".");
    }
}
