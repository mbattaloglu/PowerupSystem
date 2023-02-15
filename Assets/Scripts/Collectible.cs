using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    private void Update()
    {
        transform.Rotate(1 * rotationSpeed * Time.deltaTime, 1 * rotationSpeed * Time.deltaTime, 1 * rotationSpeed * Time.deltaTime);
    }
}
