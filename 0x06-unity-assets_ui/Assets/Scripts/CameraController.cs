using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    public Transform player;
    //private float rotation = 0f;
    public float turnSpeed = 5f;


    void Start()
    {
        offset = transform.position - player.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;

        Vector3 desiredPosition = player.position + offset;
        transform.position = desiredPosition;
        transform.LookAt(player.position);

        // Rotate the player
        player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * Vector3.up);



    }
}
