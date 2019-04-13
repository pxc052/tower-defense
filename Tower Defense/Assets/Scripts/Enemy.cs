using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public int health = 100;
    public int value = 50;
    public GameObject deathEffect;
    private Transform target;
    private int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    public void TakeDamgae(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        PlayerStats.Money += value;
        Destroy(effect, 5f);
        Destroy(gameObject);
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.waypoints.Length - 1)
        {
            Destroy(gameObject);
            PlayerStats.Lives--;
            return;
        }
        waypointIndex++;
        target = Waypoints.waypoints[waypointIndex];
    }
}
