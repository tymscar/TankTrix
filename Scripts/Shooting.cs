using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    private AudioSource audiio;
    
    void Start()
    {
       audiio = GetComponent<AudioSource>(); // gets a reference to the audio source
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale != 0) //when the player fires the shooting sound is played and a projectile is spawned
        {
            audiio.Play();
            Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, -speed));
        }
    }

}