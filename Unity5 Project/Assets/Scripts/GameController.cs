using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject Player;
    public GameObject enemyTank;
    public int Score;
    public int Lives;
    public Text ScoreText;
    public Text LivesText;
    private GameObject enemyTankPrefab;
    public int DistOnZ
    {
        get
        {
            return DistanceOnZ;
        }
        set
        {
            DistanceOnZ = value;
        }
    }
    private int DistanceOnZ;
    public bool GameOver;
    public Text GameOverText;

    IEnumerator spawning()
    {
        while ("cats" != "dogs") //infinite loop
        {
            DistanceOnZ = Random.Range(10, 100); //Spawns at a random distanc e on the Z axis from 10 to 100 units
            yield return new WaitForSeconds(3); //This is the wait before reentering the loop
            enemyTankPrefab = Instantiate(enemyTank, Player.transform.position + Player.transform.forward * -1 * DistanceOnZ , Quaternion.identity) as GameObject; //the tank is spawned
            Vector3 newPosition = enemyTankPrefab.transform.position;// the position is stored in a new vector3
            newPosition.y = Player.transform.position.y; // the y position is tailored toweards the players y position
            enemyTankPrefab.transform.position = newPosition; //the new position is applied to the recentyly spawned tank
        }
    }

    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        GameOverText.enabled = false; //Makes the end game text invisible
        GameOver = false; //this bool is used all over the game to know if its over or not
        Score = 0; //resets the score
        Lives = 3; //resets the lives
        StartCoroutine(spawning()); //Starts the spawning loop
    }
    void Update()
    {
        ScoreText.text = " Score: " + Score; //updates the score text
        LivesText.text = "Lives: " + Lives + " "; // Updates the lives text
        if (Lives <= 0 || Player.gameObject.transform.position.y <= -4) //if there are no more lives left or the player fell fo the map then its game over and the game is paused
        {
            Lives = 0;
            // Game Over!
            GameOver = true;
            GameOverText.enabled = true;
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetButtonDown("Submit")) // reset the game when submit or r are pressed
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.P) && GameOver == false) //pauses and unpauses the game when its not game over by pressing "p"
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else {
                Time.timeScale = 0;
            }
        }

    }
}
