using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private float _movementTime;
    private bool _up;

    void Update()
    {
        if (_movementTime < 1)
        {
            _movementTime += Time.deltaTime;

            if (_up)
                transform.position += new Vector3(0, 0.01f, 0);
            else
                transform.position += new Vector3(0, -0.01f, 0);
        }
        else
        {
            _movementTime = 0;
            _up = !_up;
        }
    }
}
