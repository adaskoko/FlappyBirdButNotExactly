using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private static int _nextLevelindex = 1;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();

    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;

        }

        Debug.Log("You killed all enemies");

        _nextLevelindex++;
        string nextLevelName = "Level" + _nextLevelindex;
        SceneManager.LoadScene(nextLevelName);
    }
}
