using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    public float movspeed = 40f;
    private GameObject player;
    private Transform target;
    public Rigidbody projectile;
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
    private float speed = 20;
    private int enemyType;
    public Material tanktype1material;
    public Material tanktype2material;
    private AudioSource audiio;
    void Start () {
        audiio = GetComponent<AudioSource>(); //get a reference to the audio file
        player = GameObject.FindGameObjectWithTag("Player"); //gets a reference to the player
        target = player.transform; // targets the player
        if (Random.Range(1, 100) % 3 == 0) //decides what kind of enemy it is going to be
        {
            enemyType = 2;
            GetComponent<Renderer>().material = tanktype2material; //changes the colour acordingly
        }
        else
        {
            enemyType = 1;
            GetComponent<Renderer>().material = tanktype1material; //changes the colour acordingly
        }
        StartCoroutine(shooting()); //starts the shooting loop
    }


    void Update()
    {
            if (target != null) //if there is a target look at it and follow it
            {
                transform.LookAt(target);
                transform.Rotate(new Vector3(0, 180, 0));
            }
            transform.Translate(new Vector3(0,0,movspeed *  Time.deltaTime * -1));
    }


    IEnumerator shooting()
    {
        while (137 == 137) //infinite loop
        {
            if (enemyType == 1) //depending on the enemy type it shoots faster or slower and at diferent speeds
            {
                audiio.Play();
                yield return new WaitForSeconds(1.5f);
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, -speed));
                yield return new WaitForSeconds(0.5f);
            }
            else
                if (enemyType == 2)
            {
                audiio.Play();
                yield return new WaitForSeconds(0.25f);
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, -speed * 2.5f));
                yield return new WaitForSeconds(0.25f);
            }
        }
    }
}
