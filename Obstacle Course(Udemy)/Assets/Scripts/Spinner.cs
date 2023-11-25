using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yAngle = 25.0f;
    [SerializeField] float rotationSpeed = 5.0f;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        float yRotation = yAngle * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, yRotation);
    }
}
