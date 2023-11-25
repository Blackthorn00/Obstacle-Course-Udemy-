using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer objRenderer;
    Rigidbody rb;
    BoxCollider boxCollider;
    [SerializeField] float timeToWait = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();

        rb.useGravity = false;
        objRenderer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeToWait > Time.time)
        {
            rb.useGravity = true;
            objRenderer.enabled = true;
        }
    }
}
