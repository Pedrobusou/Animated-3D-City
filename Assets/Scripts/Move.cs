using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 1;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
