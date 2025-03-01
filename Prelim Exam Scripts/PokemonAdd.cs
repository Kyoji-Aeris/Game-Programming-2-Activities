using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Linq;
public class PokemonAdd : MonoBehaviour
{
    public PokemonManager pokemonManager;
    public TMP_InputField nameInput;
    public TMP_InputField levelInput;
    public TMP_InputField genderField;
    public TMP_InputField typeField;

    public void AddPokemon()
    {
        Pokemon newPokemon = new()
        {
            pokemonName = nameInput.text,
            level = int.Parse(levelInput.text),
            gender = genderField.text,
            element = typeField.text
        };

        pokemonManager.pokemons.Add(newPokemon);
    }
}
