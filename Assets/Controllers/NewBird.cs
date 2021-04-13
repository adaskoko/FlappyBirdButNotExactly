using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class NewBird : MonoBehaviour
{
    private float _timeSittingAround;

    [SerializeField] private float _velocity = 2;

    [SerializeField] private GameObject _cloudParticlePrefab;

    public AudioSource whistleSound;
    public AudioSource poopSound;

    public GameObject poopPrefab;

    private BirdControls _controls;

    bool rightHeld;
    bool leftHeld;

    AudioSource audio;

    private void Awake()
    {
        _controls = new BirdControls();
        _controls.Bird.FlyUp.performed += ctx => HandleFlyUp();
        _controls.Bird.MoveLeft.performed += ctx => MoveLeft();
        _controls.Bird.MoveRight.performed += ctx => MoveRight();
        _controls.Bird.Shoot.performed += ctx => Shoot();
        _controls.Menu.Menu.performed += ctx => ShowMenu();

        audio = GetComponent<AudioSource>();
        audio.volume = LvlController.volume;

        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "Lvl1")
            LvlController.lvl1Score = 0;
        else
            LvlController.lvl2Score = 0;
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void HandleFlyUp()
    {
        Vector2 force = new Vector2(0, 300);
        GetComponent<Rigidbody2D>().AddForce(force);
    }

    private void MoveRight()
    {
        rightHeld = !rightHeld;       
    }

    private void MoveLeft()
    {
        leftHeld = !leftHeld;
    }

    private void ShowMenu()
    {
        SceneManager.LoadScene("End");
    }

    private void Shoot()
    {
        Instantiate(poopPrefab, new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z), transform.rotation);

        GetComponent<Animator>().Play("BirdPoop");
        poopSound.Play();
    }

    private void Update()
    {
        if(!(rightHeld && leftHeld))
        {
            if (rightHeld)
            {
                Vector3 velocity = new Vector3(_velocity, GetComponent<Rigidbody2D>().velocity.y, 0);
                GetComponent<Rigidbody2D>().velocity = velocity;
            }
            else if (leftHeld)
            {
                Vector3 velocity = new Vector3((-1) * _velocity, GetComponent<Rigidbody2D>().velocity.y, 0);
                GetComponent<Rigidbody2D>().velocity = velocity;
            }
            else
            {
                Vector3 velocity = new Vector3(0, GetComponent<Rigidbody2D>().velocity.y, 0);
                GetComponent<Rigidbody2D>().velocity = velocity;
            }
        }

        if (GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1f)
        {
            _timeSittingAround += Time.deltaTime;
        }

        if(_timeSittingAround > 2)
        {
            GetComponent<Animator>().Play("Whistle");
            whistleSound.Play();
            _timeSittingAround = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Laser laser = collision.collider.GetComponent<Laser>();
        if (laser != null)
        {
            StartCoroutine(KillBird());
        }

        Spikes spikes = collision.collider.GetComponent<Spikes>();
        if (spikes != null)
        {
            StartCoroutine(KillBird());
        }

        Finish finish = collision.collider.GetComponent<Finish>();
        if (finish != null)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            if (currentSceneName == "Lvl1")
                SceneManager.LoadScene("Lvl2");
            else
                SceneManager.LoadScene("End");
        }

    }

    private void RestartScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    private IEnumerator KillBird()
    {
        Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
        
        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);

        RestartScene();
    }

}
