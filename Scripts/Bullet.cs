using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public int randomDirection
    {
        get
        {
            return randomDir;
        }
        set
        {
            randomDir = value;
        }
    }
    private int randomDir;
    Vector3 initialPos;
    Vector3 newPos;
    private float t = 0;
    public GameController gamecontroller;
    // Use this for initialization
    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>(); // GEtting a reference to the main gamecontroller script
    }


    void OnTriggerEnter(Collider other) //Calling this methode if the bullets collides with anything
    {
        Debug.Log(other); //Debug for testing purposes
        if (other.tag == "Tree") //if it collides with the tree destroythe tree and the bullet
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        if (other.tag == "Tank") //if it collides with an enemy destroy the enemy increment the score and destroy the bullet
        {
            gamecontroller.Score++;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        if(other.tag == "Evade") //if it collides with the evade stick than get a random direction and move the enemy there. (this is so the enemy tries to avoid the bullet
        {
            if (Random.Range(1, 100) % 2 == 0)
                randomDir = 1;
            else
                randomDir = -1;
            initialPos = other.transform.parent.gameObject.transform.position;
            other.transform.parent.gameObject.transform.Rotate(new Vector3(0, 90 * randomDir, 0));
            other.transform.parent.gameObject.transform.Translate(new Vector3(0, 0, 40 * Time.deltaTime * -1.5f));
            newPos = other.transform.parent.gameObject.transform.position;
            other.transform.parent.gameObject.transform.position = initialPos;
            StartCoroutine(TankTransition(other.gameObject, initialPos, newPos));
        }
        else
        if (other.tag != "CrossHair" && other.tag != "Evade") // if it doesent collide with anything specified then jsut destroy the bullet
            Destroy(this.gameObject);
    }

    IEnumerator TankTransition(GameObject tankobj, Vector3 startpos,Vector3 endpos)
    {
        while (t < 1.0f)
        {
            t += 0.1f;
            tankobj.transform.parent.gameObject.transform.position = Vector3.Lerp(startpos, endpos, t);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
