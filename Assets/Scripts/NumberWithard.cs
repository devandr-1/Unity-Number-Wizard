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
    TextMeshProUGUI guessText;

    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHeigher()
    {
        min = guess;
        ToCountGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        ToCountGuess();
    }

    private void ToCountGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }

    private void StartGame()
    {
        ToCountGuess();
        max += 1;
    }
}
