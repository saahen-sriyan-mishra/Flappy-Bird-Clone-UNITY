using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleLogic : MonoBehaviour
{


    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.7f, -1.9f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isPlaying)
        {
            transform.position = transform.position + new Vector3(-GameManager.ObsVelocity * Time.deltaTime, 0, 0);
            
            if (transform.position.x < -3)
            {
                transform.position = new Vector3(3, Random.Range(-0.7f, -1.7f) , 0);
            }
        }
    }
}
