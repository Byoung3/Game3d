using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has beaten Level 1! Switching scenes...");
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        // Load the scene by its name
        SceneManager.LoadScene(sceneToLoad);
    }
}