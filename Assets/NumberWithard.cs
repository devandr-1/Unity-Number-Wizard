using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWithard : MonoBehaviour
{
    private int max = 1000;
    private int min = 1;
    private int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Withard");
        Debug.Log("Pick a number");
        Debug.Log($"The highest number you can pick is: { max }");
        Debug.Log($"The lowest number you can pick is: { min }");

        Debug.Log($"Tell me if your number is higher or lower than { guess }");
        Debug.Log("Push Up if it's higher or push Down if it's lower");
        Debug.Log("Push Enter if it's correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You have pressed Up Key");
            min = guess;

        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You have pressed Down Key");
            max = guess;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You have pressed Enter");
        }
    }
}
