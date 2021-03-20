using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Reference to the player
    public Transform player; 
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
