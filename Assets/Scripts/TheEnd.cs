using UnityEditor;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has beaten Level 2!");
        Debug.Log("You have completed the game!!");
        Debug.Log("Quitting Application");
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
