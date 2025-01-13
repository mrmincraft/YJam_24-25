
using UnityEngine;

public class Example : MonoBehaviour
{
    public Vector3 MyPos3; 
    public Transform Character; 
    public float XLimit = 7f; 
    public float YLimit = 3f; 

    void Update()
    {
        Vector3 cameraPos = transform.position;

       
        if (Character.position.x > cameraPos.x + XLimit)
        {
            cameraPos.x = Character.position.x - XLimit;
        }
        if (Character.position.x < cameraPos.x - XLimit)
        {
            cameraPos.x = Character.position.x + XLimit;
        }
        if (Character.position.y > cameraPos.y + YLimit)
        {
            cameraPos.y = Character.position.y - YLimit;
        }
        else if (Character.position.y < cameraPos.y - YLimit)
        {
            cameraPos.y = Character.position.y + YLimit;
        }

        transform.position = new Vector3(cameraPos.x, cameraPos.y,-10);
    }
}

