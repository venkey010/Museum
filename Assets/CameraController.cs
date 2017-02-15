using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    CharacterController c;
	
	void Start () {
        c = GetComponent<CharacterController>();
	}
	
	
	void Update () {
	        if (Input.GetKey(KeyCode.UpArrow))
        {
            c.SimpleMove(Camera.main.transform.forward * 5);
        }
            if (Input.GetKey(KeyCode.DownArrow))
        {
            c.SimpleMove(-Camera.main.transform.forward * 5);
        }
	}
}
