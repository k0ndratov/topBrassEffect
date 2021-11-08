using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpToLevel : MonoBehaviour
{
    [SerializeField] private string nextScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextScene);
    }
}
