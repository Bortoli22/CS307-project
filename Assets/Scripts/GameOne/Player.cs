﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //GameObject player;
    public Transform target;
    public GameObject[] Enemy;

    Vector3 StartPoint;

    void Start()
    {
        StartPoint = transform.position;
    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Check"))
        {
            int i = 0;
            while (i < Enemy.Length - 1)
            {
                Enemy[i].gameObject.SetActive(true);
                i++;
            }
        }
        if (other.gameObject.CompareTag("Check2"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.gameObject.CompareTag("Check3"))
        {
            Enemy[Enemy.Length - 1].gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //transform.position = StartPoint;
        }
        if (collision.gameObject.CompareTag("MainPortal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
