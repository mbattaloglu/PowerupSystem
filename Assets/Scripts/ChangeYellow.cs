using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangeYellow", menuName = "Powerup/ChangeYellow")]
public class ChangeYellow : PowerupEffect
{
    public override void Apply(GameObject gameObject)
    {
        // Change the color of the player to yellow
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
