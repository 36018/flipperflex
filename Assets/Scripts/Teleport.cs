using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Teleport : MonoBehaviour
{

    private GameObject ball;
    public GameObject teleport_exit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball")
        {
            ball = other.gameObject;
            other.gameObject.SetActive(false);
            StartCoroutine(WaitForTeleport());
        }
    }

    IEnumerator WaitForTeleport(){


        yield return new WaitForSeconds(0.4f);
        ball.transform.position = teleport_exit.transform.position;
        ball.SetActive(true);
    }

}
