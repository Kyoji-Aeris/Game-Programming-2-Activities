using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orpheus : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Orpheus";
        level = 1;
        arcana = Arcana.Fool;

        strength = 2;
        magic = 2;
        endurance = 2;
        agility = 2;
        luck = 2;
    }
}
