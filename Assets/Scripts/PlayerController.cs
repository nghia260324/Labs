using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float moveSpeed = 3f;
    public float jumpHeight = 5f;
    Rigidbody2D rigidbody2D;
    Animator animator;
    bool grounded = false;

    int coin = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(move * moveSpeed, rigidbody2D.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(move));

        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded)
            {
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpHeight);
            }
        }
        if (move != 0)
        {
            if (move > 0)
            {
                transform.localScale = new Vector3(0.7f, 0.7f, 0);
            }
            else
            {
                transform.localScale = new Vector3(-0.7f, 0.7f, 0);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            grounded = false;
        }
    }

    public void SetCoin()
    {
        coin++;
        textMeshPro.SetText("Coin:" + coin.ToString());
    }
}
