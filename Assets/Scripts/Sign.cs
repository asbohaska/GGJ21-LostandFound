using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {
    public Camera camera1;
    public float maxDistance = 1f;

    void FixedUpdate(){
        RaycastHit hit;
        Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit,maxDistance)) {
            Transform objectHit = hit.transform;
         Debug.Log(hit.collider.tag);
            if (objectHit.tag == "lostsign"){
                Debug.Log("Looking at Sign");
                GameManager.Instance.isLookingAtSign = true;
            } else {
                GameManager.Instance.isLookingAtSign = false;
            }
        } else {
            GameManager.Instance.isLookingAtSign = false;
        }
    }
    private void OnDrawGizmos(){
        Color cameracolor = Color.yellow;
        Debug.DrawRay(camera1.transform.position, camera1.transform.forward * maxDistance, cameracolor);
    }
}