using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Place2DObject : MonoBehaviour
{
    public GameObject arSessionOrigin;
    public GameObject spritePrefab;

    void Start()
    {
        // Instantiate the 2D object as a child of the AR Session Origin object
        GameObject spriteObject = Instantiate(spritePrefab, arSessionOrigin.transform);

        // Set the position, rotation, and scale of the 2D object as desired
        spriteObject.transform.localPosition = new Vector3(0f, 0f, 0.5f);
        spriteObject.transform.localRotation = Quaternion.identity;
        spriteObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        // Add an AR Session component to the 2D object and set the Tracking Type to Position and Rotation
        spriteObject.AddComponent<ARSession>();
        // spriteObject.GetComponent<ARSession>().trackingType = ARSession.TrackingType.PositionAndRotation;
    }
}
