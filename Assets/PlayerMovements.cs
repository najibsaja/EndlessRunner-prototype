using System;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float sideSPD;
    public float jumpSPD;
    bool melompat;
    public int coin_counter;
    public bool loseState;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        melompat = false;
        loseState = false;
    }

    // Update is called once per frame
    void Update()
    {
        float SIDE_move = Input.GetAxis("Horizontal") * sideSPD * Time.deltaTime;
        transform.Translate(SIDE_move, 0, 0);
        Debug.Log("koin: " + coin_counter);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("coins"))
        {
            Destroy(collision.gameObject);
            coin_counter += 1;
            return;
        }

        if (collision.gameObject.CompareTag("obstacle"))
        {
            loseState = true;
        }
    }
}
