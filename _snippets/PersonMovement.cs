using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour
{
    public float movementSpeed = 8f;

    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
        InvokeRepeating("ResetPosition", 0f, 13f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

    void ResetPosition() {
        transform.position = originalPosition;
    }
}
