using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour
{
    public LevelManager levelManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("StartMenu");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
