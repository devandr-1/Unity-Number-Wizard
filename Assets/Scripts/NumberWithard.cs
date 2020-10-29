using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWithard : MonoBehaviour
{
    [SerializeField]
    int max;
    [SerializeField]
    int min;
    [SerializeField]
    TextMeshProUGUI guessText = null;

    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHeigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    private void StartGame()
    {
        NextGuess();
    }
}
