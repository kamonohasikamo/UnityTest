using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSSController : MonoBehaviour {
    float fallSpeed = 0;

    void Start()
    {

    }

    void Update()
    {
        
        if (UIController.score == 100)
        {
            fallSpeed = 0.5f;
        }
        transform.Translate(0, -fallSpeed, 0, Space.World);

        if(transform.position.y < 810)
        {
            fallSpeed = 0;
        }

        if (UIController.score == 550)
        {
            Destroy(gameObject);
        }
    }
}