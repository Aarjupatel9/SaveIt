using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    public static int MainCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        // Get the position of the two colliding objects in the (x, y) plane
        Vector3 pos1 = transform.position;
        pos1.z = 0;
        Vector3 pos2 = collision.transform.position;
        pos2.z = 0;
        Debug.Log("Collision detected in (x, y) plane!");

        // Check if the two objects overlap in the (x, y) plane
        if (
            Vector3.Distance(pos1, pos2)
            < (transform.localScale.x + collision.transform.localScale.x) / 2
        )
        {
            Debug.Log("Collision detected in (x, y) plane! in if condition");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("MainFallingObject"))
        {
            Debug.Log("OnTriggerEnter detected in (x, y) plane!");
            Debug.Log("Loading new scene...");
            int score = MainCounter;
            Debug.Log("MainCounter -- " + MainCounter);

            PlayerPrefs.SetInt("score", score);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("GameOver scene is now loadding");

            
        }
    }
}
