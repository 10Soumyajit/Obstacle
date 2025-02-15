using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void printInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("This is a basic obstacle game");
        Debug.Log("The ball is the player");
        Debug.Log("Move the player using WASD or arrow keys");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
