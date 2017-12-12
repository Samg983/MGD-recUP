using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {


 	private Rect topLeft = new Rect(0, 0, Screen.width / 2, Screen.height / 2);
    private Rect bottomLeft = new Rect(0, Screen.height / 2, Screen.width / 2, Screen.height / 2);
    private Rect topRight = new Rect(Screen.width / 2, 0, Screen.width / 2, Screen.height / 2);
    private Rect bottomRight = new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 2, Screen.height / 2);
       
       
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		/* if (Input.touchCount > 0)
        {
            Vector2 touchPos = Input.GetTouch(0).position;
            print (touchPos);
            if (topLeft.Contains(touchPos))
            {
                Debug.Log("topLeft touched");
            }
            if (bottomLeft.Contains(touchPos))
            {
                Debug.Log("bottomLeft touched");
            }
            if (topRight.Contains(touchPos))
            {
                Debug.Log("topRight touched");
            }  
            if (bottomRight.Contains(touchPos))
            {
                Debug.Log("bottomRight touched");
            }
        }
	}
	   int fingerCount = 0;
        foreach (Touch touch in Input.touches) {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                fingerCount++;
            
        }
        if (fingerCount > 0)
            print("User has " + fingerCount + " finger(s) touching the screen");
        */

    }

}
