using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palladion : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Palladion";
        arcana = Arcana.Chariot;
        level = 29;

        strength = 19;
        magic = 18;
        endurance = 25;
        agility = 18;
        luck = 14;
    }
}
