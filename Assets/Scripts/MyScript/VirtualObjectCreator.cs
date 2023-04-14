using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualObjectCreator : MonoBehaviour
{
    // Start is called before the first frame update

public GameObject objectPrefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }



public void SpawnObject(Vector3 position) {
    GameObject newObject = Instantiate(objectPrefab, position, Quaternion.identity);
}

}
