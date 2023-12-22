using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beweeg : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    [SerializeField] Transform Player;
    [SerializeField] float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Player.position = A.position - B.position   ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = B.position - Player.position;
        Player.position += delta.normalized * Time.deltaTime * speed;
        if (delta.magnitude < 0.2f)
            Player.position = A.position;
    }
}