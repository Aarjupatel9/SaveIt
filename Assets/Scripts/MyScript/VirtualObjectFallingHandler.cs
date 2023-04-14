using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualObjectFallingHandler : MonoBehaviour
{
    // Start is called before the first frame update

    // float fallingSpeed  = .09;

    private float initialYPos;
    private float resetYPos;

    public float fallSpeed = 5f;

    // public Vector3 objectInit;

    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Vector3 objectSize = meshFilter.mesh.bounds.size;

        // initiaPos = new Vector3(0, 8f + objectSize.y, 10);
        // bottomPos = new Vector3(0, -8f - objectSize.y, 10);

        initialYPos = transform.position.y;
        resetYPos = initialYPos;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // if (transform.position.y < bottomPos.y)
        // {
        //     transform.position = initiaPos;
        // }


        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -.8f)
        {
            CollisionDetector.MainCounter += 1;
            Debug.Log("FollingObject Maincounter = " + CollisionDetector.MainCounter);

            transform.position = new Vector3(transform.position.x, resetYPos, transform.position.z);
        }
    }
}
