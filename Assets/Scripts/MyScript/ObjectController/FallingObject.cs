using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = .9f;
    private float initialYPos;
    private float resetYPos;

    // private CameraDevice.CameraDirection nd = CameraDevice.CameraDirection.CAMERA_FRONT;

    void Start()
    {
        initialYPos = transform.position.y;
        resetYPos = initialYPos;
    }

    void    ()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -1f)
        {
            CollisionDetector.MainCounter += 1;
            Debug.Log("FollingObject Maincounter = " + CollisionDetector.MainCounter);
            transform.position = new Vector3(transform.position.x, resetYPos, transform.position.z);
        }

        // transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
}
