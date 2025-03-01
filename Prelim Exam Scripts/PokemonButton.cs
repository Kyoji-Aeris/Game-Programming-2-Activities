using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PokemonButton : MonoBehaviour
{
    public TextMeshProUGUI pokemonNameText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI genderText;
    
    public void SetPokemonData(Pokemon unit)
    {
        pokemonNameText.text = unit.pokemonName;
        levelText.text = unit.level.ToString();
        typeText.text = unit.element;
        genderText.text = unit.gender;
    }
}
