using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//Assets
//background: https://www.reddit.com/r/gumball/comments/y3vulz/the_amazing_world_of_gumball_as_video_game/ 
public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0.05f * Vector3.forward);
        //transform.Rotate(0f,0f,0.1f);
        //transform.Translate(0.01f *(Vector3.right + Vector3.up)

        Vector3 position = transform.position;


        // Horizontal movement (Left and Right arrows)
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1.55f)  // horizontal boundary
                transform.Translate(0f, -0.01f, 0f);  // horizontal transform
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 1.7f)  // horizontal boundary 
                transform.Translate(0f, 0.01f, 0f);  // Move right on the x-axis
        }
    }// ev
}

     //end 