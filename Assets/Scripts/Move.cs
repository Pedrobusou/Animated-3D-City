using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
