using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    [SerializeField] private float _speed = 15;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, (-1) * _speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
