using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public GameObject screen; //screen
    public GameObject player; //player
    public GameObject prefabs_Obj_Dragon;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float vertical = Input.GetAxis("Vertical");
            Vector3 jump = new Vector3(0,vertical*7,0);

            player.transform.position += jump;
        }
    }


}
