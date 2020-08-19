using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    private RaycastHit vision; // Used for detecting Raycast collection
    public float rayLength; // Used for assigning a length to the raycast
    private bool isGrabbed; // Used so we know whetehr or not we're holding an object
    private Rigidbody grabbedObject; // Used to assign the object we're looking at to a variable we can use

    // Start is called before the first frame update
    void Start()
    {
        rayLength = 4.0f;
        isGrabbed = false;
    }

    // Update is called once per frame
    void Update()
    {
        // This will constantly draw the ray in our Scene View so we can see where the ray is going
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);

        if (Input.GetMouseButtonDown(0)) {
            
            // This statement is called when the Raycast is hitting a collider in the scene
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength)) {
                
                // Determine if the object our raycast is hitting has the "Interactive" tag
                if (vision.collider.tag == "puzzle_three_letter_square") {

                    vision.collider.gameObject.GetComponent<PuzzleThreeLetterSquare>().FlipBlackOutState();
                    // if (Input.GetKeyDown (KeyCode.E) && !isGrabbed) {
                    //     grabbedObject = vision.rigidbody;
                    //     grabbedObject.isKinematic = true;
                    //     grabbedObject.transform.SetParent (gameObject.transform);
                    //     isGrabbed = true;
                    // } else if (isGrabbed && Input.GetKeyDown(KeyCode.E)) {
                    //     grabbedObject.transform.parent = null;
                    //     grabbedObject.isKinematic = false;
                    //     isGrabbed = false;
                    // }
                }
            }
        }
    }
}
