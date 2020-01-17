using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene2d : MonoBehaviour
{
    [SerializeField] private string newLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) ;
        SceneManager.LoadScene(newLevel);
    }

}
