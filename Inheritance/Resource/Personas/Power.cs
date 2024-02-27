using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Power";
        arcana = Arcana.Justice;
        level = 25;

        strength = 20;
        magic = 19;
        endurance = 15;
        agility = 16;
        luck = 12;
    }
}
