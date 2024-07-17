using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicScript logic;
    public bool birdAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        if (logic == null)
        {
            Debug.LogError("Logic script not found! Check tag or script attachment.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic != null)
        {
            logic.gameOver();
            birdAlive = false;
        }
    }
}
