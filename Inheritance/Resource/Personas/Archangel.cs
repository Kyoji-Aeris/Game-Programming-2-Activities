using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archangel : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Archangel";
        arcana = Arcana.Justice;
        level = 10;

        strength = 8;
        magic = 8;
        endurance = 8;
        agility = 7;
        luck = 6;
    }
}
