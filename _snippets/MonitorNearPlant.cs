using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorNearPlant : MonoBehaviour
{
    public CorrectPlant plant;

    // Update is called once per frame
    void Update()
    {
        bool plantTriggered = plant.GetComponent<CorrectPlant>().triggered;

        if (plantTriggered) {
            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.green); 
            }
        }
    }
}
