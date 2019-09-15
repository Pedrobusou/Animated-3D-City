using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras;
    public int nextCamera = 1;
    public float timer;

    private void Start()
    {
        //Turn all cameras off, except the first default one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        //If any cameras were added to the controller, enable the first one
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
            Debug.Log("Camera with name: " + cameras[0].name + ", is now enabled");
        }
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 4 && cameras.Length > nextCamera)
        {
            Debug.Log("change active camera");
            cameras[nextCamera].gameObject.SetActive(true); //active next camera
            cameras[nextCamera-1].gameObject.SetActive(false); //deactive previous camera
            nextCamera++;
            timer = 0;
        }

    }
}
