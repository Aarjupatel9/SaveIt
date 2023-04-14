using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMapping : MonoBehaviour
{
    public GameObject cube_1c;

    GameObject newCube1c;

    GameObject[] newObjects;

    // Start is called before the first frame update
    void Start()
    {
        // newCube1c = Instantiate(cube_1c, new Vector3(-16f, 16f, 10), Quaternion.identity);
    }

    private void init()
    {
        Debug.Log("PositionMapping || init start");
        // newObjects = MySingleton.Instance.myObject;
        newObjects = ObjectManager.newObjects;
    }

    // Update is called once per frame
    void Update()
    {
        // if (newObjects != null)
        // {
        //     Debug.Log("PositionMapping || enter in neObject if condition");
        //     Debug.Log("Position mapping || player " + transform.position);
        //     Debug.Log("Position mapping || object 0 " + newObjects[0].transform.position);

        //     for (int i = 0; i < newObjects.Length; i++)
        //     {
        //         if (DoObjectsOverlap(newObjects[i]) || DoObjectsOverlapReverse(newObjects[i]))
        //         {
        //             Debug.Log("Position mapping || object is overlaped in x and y direcction");
        //         }
        //     }
        // }
        // else
        // {
        //     Debug.Log("PositionMapping || enter in neObject else condition for init() call");
        //     init();
        // }
    }

    bool DoObjectsOverlap(GameObject obj2)
    {
        Vector3 obj1Pos = transform.position;
        Vector3 obj2Pos = obj2.transform.position;
        Vector3 obj1Size = GetComponent<BoxCollider>().size;
        Vector3 obj2Size = obj2.GetComponent<BoxCollider>().size;

        float obj1LeftEdge = obj1Pos.x - obj1Size.x / 2;
        float obj1RightEdge = obj1Pos.x + obj1Size.x / 2;
        float obj2LeftEdge = obj2Pos.x - obj2Size.x / 2;
        float obj2RightEdge = obj2Pos.x + obj2Size.x / 2;

        float obj1TopEdge = obj1Pos.y + obj1Size.y / 2;
        float obj1BottomEdge = obj1Pos.y - obj1Size.y / 2;
        float obj2TopEdge = obj2Pos.y + obj2Size.y / 2;
        float obj2BottomEdge = obj2Pos.y - obj2Size.y / 2;

        if (obj2LeftEdge < obj1RightEdge && obj1RightEdge < obj2RightEdge)
        {
            if (obj2TopEdge > obj1TopEdge && obj1TopEdge > obj2BottomEdge)
            {
                return true;
            }
            else if (obj2TopEdge > obj1BottomEdge && obj1BottomEdge > obj2TopEdge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (obj2LeftEdge < obj1LeftEdge && obj1LeftEdge < obj2RightEdge)
        {
            if (obj2TopEdge > obj1TopEdge && obj1TopEdge > obj2BottomEdge)
            {
                return true;
            }
            else if (obj2TopEdge > obj1BottomEdge && obj1BottomEdge > obj2TopEdge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    bool DoObjectsOverlapReverse(GameObject obj2)
    {
        Vector3 obj2Pos = transform.position;
        Vector3 obj1Pos = obj2.transform.position;
        Vector3 obj2Size = GetComponent<BoxCollider>().size;
        Vector3 obj1Size = obj2.GetComponent<BoxCollider>().size;

        float obj1LeftEdge = obj1Pos.x - obj1Size.x / 2;
        float obj1RightEdge = obj1Pos.x + obj1Size.x / 2;
        float obj2LeftEdge = obj2Pos.x - obj2Size.x / 2;
        float obj2RightEdge = obj2Pos.x + obj2Size.x / 2;

        float obj1TopEdge = obj1Pos.y + obj1Size.y / 2;
        float obj1BottomEdge = obj1Pos.y - obj1Size.y / 2;
        float obj2TopEdge = obj2Pos.y + obj2Size.y / 2;
        float obj2BottomEdge = obj2Pos.y - obj2Size.y / 2;

        if (obj2LeftEdge < obj1RightEdge && obj1RightEdge < obj2RightEdge)
        {
            if (obj2TopEdge > obj1TopEdge && obj1TopEdge > obj2BottomEdge)
            {
                return true;
            }
            else if (obj2TopEdge > obj1BottomEdge && obj1BottomEdge > obj2TopEdge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (obj2LeftEdge < obj1LeftEdge && obj1LeftEdge < obj2RightEdge)
        {
            if (obj2TopEdge > obj1TopEdge && obj1TopEdge > obj2BottomEdge)
            {
                return true;
            }
            else if (obj2TopEdge > obj1BottomEdge && obj1BottomEdge > obj2TopEdge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
