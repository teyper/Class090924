using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;


        // Vertical movement (Up-Down arrows)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.y < 6f)  // vertical boundary 
                transform.Translate(0f, 0.01f, 0f);  // vertical transform
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.y > -4.69f)  // vertical boudary 
                transform.Translate(0f, -0.01f, 0f);  // vertical transform
        }
        
    }
}
