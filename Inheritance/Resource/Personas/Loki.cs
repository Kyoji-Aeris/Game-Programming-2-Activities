using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loki : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Loki";
        arcana = Arcana.Fool;
        level = 58;

        strength = 41;
        magic = 47;
        endurance = 30;
        agility = 42;
        luck = 21;
    }
}
