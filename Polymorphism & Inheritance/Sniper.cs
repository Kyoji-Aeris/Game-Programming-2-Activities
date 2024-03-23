using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    public string weapon;
    public int atkNum;

    public override void Attack()
    {
        base.Attack();
        Debug.Log(weapon + " Equipped.\nAttack is increased by " + atkNum + ".");
    }
}
