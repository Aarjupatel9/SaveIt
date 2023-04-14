using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // public VirtualObjectCreator virtualObjectCreator;
    public GameObject objectPrefab;
    public GameObject fixedObjectPrefab;

    public static GameObject[] newObjects;

    public float PosZFixed = 1f;
    Vector3 objectSize;

    // Start is called before the first frame update
    void Start()
    {
        newObjects = new GameObject[6];
        MeshFilter meshFilter = objectPrefab.GetComponent<MeshFilter>();
        objectSize = meshFilter.mesh.bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObject(objectSize);
    }

    public void SpawnObject(Vector3 objectSize)
    {
        // virtualObjectCreator.SpawnObject(position);
        // GameObject newObject = Instantiate(objectPrefab, position, Quaternion.identity);


        Debug.Log("SpawnObject Method is caalled");

        if (newObjects[2] == null)
        {
            newObjects[2] = Instantiate(
                objectPrefab,
                new Vector3(0, .8f + objectSize.y, PosZFixed),
                Quaternion.identity
            );
        }

        if (newObjects[0] == null && newObjects[2] != null)
        {
            if (newObjects[2].transform.position.y < 0.1f)
            {
                newObjects[0] = Instantiate(
                    objectPrefab,
                    new Vector3(-.2f, .8f + objectSize.y, PosZFixed),
                    Quaternion.identity
                );
            }
        }

        if (newObjects[1] == null && newObjects[2] != null)
        {
            if (newObjects[2].transform.position.y < 0.1f)
            {
                newObjects[1] = Instantiate(
                    objectPrefab,
                    new Vector3(.2f, .8f + objectSize.y, PosZFixed),
                    Quaternion.identity
                );
            }
        }

        // if (newObjects[5] == null && newObjects[2] != null)
        // {
        //     newObjects[1] = Instantiate(
        //         objectPrefab,
        //         new Vector3(-.2f, 1.4f + objectSize.y, PosZFixed),
        //         Quaternion.identity
        //     );
        // }

        // newObjects[5] = Instantiate(
        //             objectPrefab,
        //             new Vector3(.2f, .8f + objectSize.y, PosZFixed),
        //             Quaternion.identity
        //         );




        // newObjects[3] = Instantiate(
        //     objectPrefab,
        //     new Vector3(0, .8f + objectSize.y, PosZFixed),
        //     Quaternion.identity
        // );




        // GameObject g1 = Instantiate(fixedObjectPrefab, new Vector3(0, 0, 10), Quaternion.identity);
        // Rigidbody rb = newObject.AddComponent<Rigidbody>();
        // rb.useGravity = true;
        // rb.gravityScale = 1f;

        // MySingleton.Instance.myObject = newObjects;
    }
}
