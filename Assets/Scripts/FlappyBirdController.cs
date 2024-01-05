using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlappyBirdController : MonoBehaviour
{
    public Image die;
    public float jumpForce;
    private Rigidbody2D m_Rigidbody2D;

    private bool isDie;

    private void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        isDie = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) { 
            m_Rigidbody2D.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tube"))
        {
            Die();
        }
    }

    private void Die()
    {
        isDie = true;
        die.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
