using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    public PokemonManager pokemonManager;
    public Transform parentPos;
    public GameObject pokemonButtonPrefab;
    public void OnClick()
    {
        Debug.Log(pokemonManager.pokemons.Count());
        foreach (Pokemon p in pokemonManager.pokemons)
        {
            Debug.Log(p);
            GameObject buttonPrefab = Instantiate(pokemonButtonPrefab, parentPos);
            PokemonButton pokemonButton = buttonPrefab.GetComponent<PokemonButton>();
            pokemonButton.SetPokemonData(p);
        }
    }
}
