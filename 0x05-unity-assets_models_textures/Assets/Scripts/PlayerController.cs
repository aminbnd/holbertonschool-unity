using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rg;
    float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // movments physics
    void FixedUpdate()
    {
        float horizontalAxisPosition = Input.GetAxis("Horizontal");
        float forwardAxisPosition = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontalAxisPosition, 0, forwardAxisPosition).normalized;
        rg.AddForce(force * speed*Time.fixedDeltaTime);


    }
}
