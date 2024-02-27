using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Slime";
        arcana = Arcana.Fool;
        level = 12;

        strength = 9;
        magic = 9;
        endurance = 7;
        agility = 8;
        luck = 10;
    }
}
