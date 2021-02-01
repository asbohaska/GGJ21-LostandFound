using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
     camera1.enabled = true;
     camera2.enabled = false;   
    }

    // Update is called once per frame (Only click when click and cat)
    void Update()
    {
     if (Input.GetMouseButtonDown(0) && camera1.enabled && GameManager.Instance.isLookingAtSign){
         camera1.enabled = !camera1.enabled;
         camera2.enabled = !camera2.enabled;
        camera1.GetComponent<AudioListener>().enabled = !camera1.GetComponent<AudioListener>().enabled;
        camera2.GetComponent<AudioListener>().enabled = !camera2.GetComponent<AudioListener>().enabled;
     StartCoroutine("Switch");
     }   
    }
    IEnumerator Switch()
    {
     yield return new WaitForSeconds (5);
     camera1.enabled = !camera1.enabled;
     camera2.enabled = !camera2.enabled;
     camera1.GetComponent<AudioListener>().enabled = !camera1.GetComponent<AudioListener>().enabled;
     camera2.GetComponent<AudioListener>().enabled = !camera2.GetComponent<AudioListener>().enabled;
    }
}