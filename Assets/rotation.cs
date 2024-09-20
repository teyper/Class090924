using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 0.1f;
    public float translationSpeed = 0.01f;

    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //rotate about y axis
        transform.Rotate(0f, 0f, rotationSpeed);

        //move ball diagonally
        //transform.Translate(translationSpeed * (Vector3.right + Vector3.up));

        //transform.Rotate(0.05f * Vector3.forward);
        //transform.Rotate(0f,0f,0.1f);
        //transform.Translate(0.01f * (Vector3.right + Vector3.up);
    }
}
