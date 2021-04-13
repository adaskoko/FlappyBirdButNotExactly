using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Poop poop = collision.collider.GetComponent<Poop>();
        if (poop != null)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            if (currentSceneName == "Lvl1")
                LvlController.lvl1Score++;
            else
                LvlController.lvl2Score++;

            GetComponent<Rigidbody2D>().gravityScale = 1;
        }

        Laser laser = collision.collider.GetComponent<Laser>();
        if (laser != null)
        {
            Destroy(gameObject);
        }
    }
}
