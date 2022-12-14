using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    private void Update() {
        if (Input.touchCount == 0)
            return;

        var touch = Input.GetTouch(0);
        switch(touch.phase){
            case TouchPhase.Began:
                Debug.Log("Began");
                break;
            case TouchPhase.Stationary:
                Debug.Log("Stationary");
                break;
            case TouchPhase.Moved:
                Debug.Log("Moved");
                break;
            case TouchPhase.Ended:
                Debug.Log("Ended");
                break;
            case TouchPhase.Canceled:
                Debug.Log("Canceled");
                break;

            default:
                break;
        }
    }
}
