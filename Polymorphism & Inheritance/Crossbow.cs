using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : Archer
{
    public string weapon;
    public int spread;

    public override void Attack()
    {
        base.Attack();
        Debug.Log(weapon + " Equipped.\nSpread is " + spread + ".");
    }
}
