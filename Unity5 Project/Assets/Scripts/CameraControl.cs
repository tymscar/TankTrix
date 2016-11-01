using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    private float speed;
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
    public GameObject playerModel;
    float h = 0f;
    float v = 0f;
    float minv = -60f;
    float maxv = 60f;
    public GameController gamecontroller;

    void Start () {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>(); //gets a reference to the gamecontroller script
        speed = 15.0f;
    }
	
	void Update () {
        if (gamecontroller.GameOver == false) //if its not game over then the player can move the camera with the mosue or the right thumbstick
        {
            h = speed * (Input.GetAxis("Mouse X") + Input.GetAxis("Joystick X")) + playerModel.transform.localEulerAngles.y;
            v += speed * (Input.GetAxis("Mouse Y") - Input.GetAxis("Joystick Y"));
            v = Mathf.Clamp(v, minv, maxv);
            transform.localEulerAngles = new Vector3(-v, 0, 0);
            playerModel.transform.localEulerAngles = new Vector3(0, h, 0);
        }
    }
}
