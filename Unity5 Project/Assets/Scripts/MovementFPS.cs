using UnityEngine;
using System.Collections;

public class MovementFPS : MonoBehaviour {

    public int MovSpeed
    {
        get
        {
            return movspeed;
        }
        set
        {
            movspeed = value;
        }
    }
    private int movspeed = 3;
	void Update () {
        Vector3 movement = new Vector3(0, 0, 0);
        movement = new Vector3(movspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, movspeed * Input.GetAxis("Vertical") * Time.deltaTime); //moves using the horizontal and vertical axis. This works on a controller and on the keyboard and mouse combo
        transform.Translate(movement);

    }
}
