using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectPlant : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    public bool triggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            _isInsideTrigger= true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            _isInsideTrigger= false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isInsideTrigger) {
            if(Input.GetKey("f")) {
                triggered = true;
            }
        }
    }
}
