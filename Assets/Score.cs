using UnityEngine;

public class Score : MonoBehaviour
{
    
    void Update()
    {
        Debug.Log("Hei");
    }

    void onCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }
}
