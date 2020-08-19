using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleThree : MonoBehaviour
{
    public bool solved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!solved) {
            PuzzleThreeLetterSquare[] squares = GetComponentsInChildren<PuzzleThreeLetterSquare>();

            if (squares[0].blackedOut && squares[1].blackedOut && squares[2].blackedOut &&
            squares[3].blackedOut && !squares[4].blackedOut && !squares[5].blackedOut &&
            !squares[6].blackedOut && !squares[7].blackedOut && squares[8].blackedOut &&
            !squares[9].blackedOut && squares[10].blackedOut && squares[11].blackedOut &&
            squares[12].blackedOut && squares[13].blackedOut && squares[14].blackedOut) {
                solved = true;

                Component[] renderers = this.GetComponentsInChildren<Renderer>();

                foreach (Renderer renderer in renderers) { 
                    renderer.material.SetColor("_Color", Color.green); 
                }
            }
        }
    }
}
