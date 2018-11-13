using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAppear : MonoBehaviour {

    public GameObject dragon_1, dragon_2, dragon_3;

    public float appearRate;

    float nextAppear = 0f;

    int sideAppear;
    int dragons;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        RandomAppear();
    }

    void RandomAppear()
    {
        if (Time.time > nextAppear)
        {
            dragons = Random.Range(1, 3);
            sideAppear = Random.Range(1, 2);

            float horizontal = Input.GetAxis("Horizontal");
            if (dragons == 1)
                {
                    dragon_1.transform.position += new Vector3(0 * 1, 0, 0);
                    Instantiate(dragon_1, transform.position, Quaternion.identity);
                    
                }
                else if (dragons == 2)
                {
                    
                    Instantiate(dragon_2, transform.position, Quaternion.identity);
                    dragon_2.transform.position += new Vector3(-3.76f * 0.5f, Random.Range(-2.19f, 0.74f), 0);
                }
                else
                {
                    
                    Instantiate(dragon_3, transform.position, Quaternion.identity);
                    dragon_3.transform.position += new Vector3(-3.76f * 0.5f, Random.Range(-2.19f, 0.74f), 0);
                }

                nextAppear = Time.time + appearRate;
            }
        
    }
}
