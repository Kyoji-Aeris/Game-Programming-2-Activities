using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimera : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Chimera";
        arcana = Arcana.Chariot;
        level = 9;

        strength = 8;
        magic = 4;
        endurance = 9;
        agility = 8;
        luck = 5;
    }
}
