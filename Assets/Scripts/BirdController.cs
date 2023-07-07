using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody2D;
    [SerializeField] private float upForce = 20f;
    [SerializeField] private Logic logic;

    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            birdRigidbody2D.velocity = Vector2.up * upForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        logic.gameOver();
    }
}
