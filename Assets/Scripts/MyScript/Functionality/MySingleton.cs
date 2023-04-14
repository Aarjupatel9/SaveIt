using UnityEngine;
    

public class MySingleton : MonoBehaviour {
    private static MySingleton _instance;

    public static MySingleton Instance {
        get {
            if (_instance == null) {
                _instance = FindObjectOfType<MySingleton>();

                if (_instance == null) {
                    GameObject singleton = new GameObject();
                    _instance = singleton.AddComponent<MySingleton>();
                    singleton.name = "MySingleton";
                }
            }

            return _instance;
        }
    }

    public GameObject myObject;
}
