using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleThreeLetterSquare : MonoBehaviour
{
    public bool blackedOut = false;

    void Update() {

    }

    public void FlipBlackOutState() {
        if (blackedOut) {
            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.white); 
            }
        } else {
            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.black); 
            }
        }

        blackedOut = !blackedOut;
    }
}
