using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingscript : MonoBehaviour
{
    public Vector3 rotateChange;
    //public Vector3 positionChange;
    //public Vector3 scalechange;
    //public float speed;

    //private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange);
        //transform.position += positionChange;
        //transform.localScale += scalechange;
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
    }
}
