using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScrolling : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousePositionX = Input.mousePosition.x;
        float moveAmount = 20f;

        float edgeSize = 10f;
        if(mousePositionX > Screen.width - edgeSize && transform.position.x <= 14.7)
        {
            transform.Translate(moveAmount * Time.deltaTime,0,0);
        }
        if(mousePositionX < edgeSize && transform.position.x >= -11.2)
        {
            transform.Translate(-moveAmount * Time.deltaTime, 0, 0);
        }
        
        
    }
}
