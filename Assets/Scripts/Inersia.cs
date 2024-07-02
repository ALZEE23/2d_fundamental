using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inersia : MonoBehaviour
{

    public Vector2 posisi;
    public int kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        posisi = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posisi += Vector2.right * kecepatan * Time.deltaTime;

        transform.position = posisi;
    }
}
