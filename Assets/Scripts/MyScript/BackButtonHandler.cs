using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class BackButtonHandler : MonoBehaviour
    {
        [SerializeField]
        GameObject m_BackButton;

        public GameObject backButton
        {
            get => m_BackButton;
            set => m_BackButton = value;
        }

        void Start()
        {
            if (Application.CanStreamedLevelBeLoaded("Menu"))
                m_BackButton.SetActive(true);
        }

        void Update()
        {
            // Handles Android physical back button
            if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
                BackButtonPressed();
        }

        public void BackButtonPressed()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Debug.Log("you hit back button");
        }
    }
}
