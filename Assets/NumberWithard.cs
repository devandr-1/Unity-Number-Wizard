using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWithard : MonoBehaviour
{
    private int max;
    private int min;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a genius!");
            StartGame();
        }
    }

    private void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log($"Is it higher or lower than { guess }");
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Withard");
        Debug.Log("Pick a number");
        Debug.Log($"The highest number you can pick is: { max }");
        Debug.Log($"The lowest number you can pick is: { min }");
        Debug.Log($"Tell me if your number is higher or lower than { guess }");
        Debug.Log("Push Up if it's higher or push Down if it's lower");
        Debug.Log("Push Enter if it's correct");
        max += 1;
    }
}
