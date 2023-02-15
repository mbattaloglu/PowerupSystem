using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangeGreen", menuName = "Powerup/ChangeGreen")]
public class ChangeGreen : PowerupEffect
{
    public override void Apply(GameObject gameObject)
    {
        // Change the color of the player to green
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
