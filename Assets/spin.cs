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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.x > -6f)  // horizontal boundary
                transform.Translate(-0.01f, 0f, 0f);  // horizontal transform
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.x < 6f)  // horizontal boundary 
                transform.Translate(0.01f, 0f, 0f);  // Move right on the x-axis
        }
    }// ev
}

     //if (Input.GetKey(KeyCode.RightArrow))
     // {
     // if (transform.position.x < 4.99f)
     //  transform.Translate(0.01f, 0f, 0f);
     //} //end right

// if (Input.GetKey(KeyCode.LeftArrow))
//{
// if (transform.position.x > -5f)
//   transform.Translate(-0.01f, 0f, 0f);
//} //end left