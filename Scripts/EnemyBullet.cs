using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
    private GameController gamecontroller;

    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>(); //get a reference for the gamecontroller
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player") //if the enemy bullet collides with the player then the player looses lives.
        {
            gamecontroller.Lives--;
        }
    }
}
