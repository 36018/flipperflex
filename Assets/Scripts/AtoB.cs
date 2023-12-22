using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtoB : MonoBehaviour
{
    [SerializeField]Transform A;
    [SerializeField]Transform B;
    [SerializeField]Transform Player;
    [SerializeField]float speed;


    // Start is called before the first frame update
    void Start()
    {
        Player.position = A.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = B.position - Player.position;
        Player.position += delta.normalized * speed * Time.deltaTime;

        if (delta.magnitude < 0.1f) {
            Player.position = A.position;
        }
    }
}
