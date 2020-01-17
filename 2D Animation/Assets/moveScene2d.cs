using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene2d : MonoBehaviour
{
    [SerializeField] private string newLevel;
    void onTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test1");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("test");
            SceneManager.LoadScene(newLevel);
        }
    }

}
