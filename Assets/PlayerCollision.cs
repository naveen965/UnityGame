using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void onCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
        }
    }
}
