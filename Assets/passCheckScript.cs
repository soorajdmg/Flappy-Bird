using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class passCheckScript : MonoBehaviour
{
    public logicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        if (logic == null)
        {
            Debug.LogError("Logic script not found! Check tag or script attachment.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (logic != null)
        {
            logic.increaseScore();
        }
    }
}
