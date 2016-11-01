using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrossHair : MonoBehaviour {
    public Image CrossHairImg;
    public Sprite redSprite;
    public Sprite greenSprite;

    //this whole script amkes sure that the crosshair is red when an enemy is inside it and green otherwise

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tank")
            CrossHairImg.sprite = redSprite;
        if(other.tag != "Tank")
            CrossHairImg.sprite = greenSprite;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tank")
            CrossHairImg.sprite = greenSprite;
    }
}
