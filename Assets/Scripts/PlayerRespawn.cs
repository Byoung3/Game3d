using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint; // Assign your RespawnPoint GameObject here in the Inspector
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        if (characterController == null)
        {
            Debug.LogError("CharacterController not found on this GameObject!");
            enabled = false; // Disable the script if no CharacterController is present
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Lava" tag
        if (collision.gameObject.CompareTag("Lava") || collision.gameObject.CompareTag("Enemy"))
        {
            RespawnPlayer();
        }
    }
    void RespawnPlayer()
    {
        if (respawnPoint != null && characterController != null)
        {
            // Disable the CharacterController temporarily to reset its position
            characterController.enabled = false;
            transform.position = respawnPoint.position;
            // Re-enable the CharacterController
            characterController.enabled = true;
        }
        else
        {
            Debug.LogWarning("Respawn point or CharacterController not assigned/found.");
        }
    }
}