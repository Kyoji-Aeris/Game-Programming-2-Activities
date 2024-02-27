using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Angel";
        arcana = Arcana.Justice;
        level = 4;

        strength = 4;
        magic = 5;
        endurance = 3;
        agility = 4;
        luck = 3;
    }
}
