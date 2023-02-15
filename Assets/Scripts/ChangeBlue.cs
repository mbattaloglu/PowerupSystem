using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangeBlue", menuName = "Powerup/ChangeBlue")]
public class ChangeBlue : PowerupEffect
{
    public override void Apply(GameObject gameObject)
    {
        // Change the color of the player to blue
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}
