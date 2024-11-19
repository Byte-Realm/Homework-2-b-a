//using UnityEngine;

//public class MinimapCamera : MonoBehaviour
//{
//    public Transform player;  // Assign your player Transform in the Inspector
//    public float height = 10f; // Height of the minimap camera above the player
//    public float smoothSpeed = 5f; // Smoothness factor for camera movement

//    private void LateUpdate()
//    {
//        // Check if the player Transform is assigned
//        if (player == null)
//        {
//            Debug.LogWarning("Player Transform is not assigned to the MinimapCamera script!");
//            return;
//        }

//        // Target position for the minimap camera
//        Vector3 targetPosition = new Vector3(player.position.x, player.position.y + height, transform.position.z);

//        // Smoothly move the camera towards the target position
//        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

//        // Ensure the camera is looking straight down
//        //transform.rotation = Quaternion.Euler(90f, 0f, 0f);
//    }
//}
