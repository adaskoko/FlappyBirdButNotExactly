using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    private float _movementTime;
    private bool _right;

    bool moving;

    void Update()
    {
        if (_movementTime < 2)
        {
            _movementTime += Time.deltaTime;

            if (_right)
                transform.position += new Vector3(0.01f, 0, 0);
            else
                transform.position += new Vector3(-0.01f, 0, 0);
        }
        else
        {
            _movementTime = 0;
            _right = !_right;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<NewBird>() != null)
        {
            collision.collider.transform.SetParent(transform);
            moving = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (moving)
        {
            collision.collider.transform.SetParent(null);
        }
    }
}
