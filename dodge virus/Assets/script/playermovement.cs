using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject shield;
    private Rigidbody2D rb;

    float max= 1.97f;
    float min= -1.97f;
    float input;
    public GameObject gameoverpanle;
    private void Awake()
    {
        gameoverpanle.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    public void right()
    {
        rb.velocity = new Vector2(5, rb.velocity.y);
    }

    public void left()
    {
        rb.velocity = new Vector2(-5, rb.velocity.y);
    }

    void Update()
    {
        input = Input.GetAxis("Horizontal");
        Vector2 crtpos =transform.position;
        if(input>0)
        {
            crtpos.x += speed * Time.deltaTime;
        }
        else if(input<0)
        {
            crtpos.x -= speed * Time.deltaTime;
        }

        
        if(crtpos.x<min)
        {
            crtpos.x = min;
        }
        if(crtpos.x>max)
        {
            crtpos.x = max;
        }
        transform.position = crtpos;
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="bomb")
        {
            Destroy(gameObject);
            Time.timeScale = .2f;
            Time.fixedDeltaTime = 0.03f * Time.timeScale;
            gameoverpanle.SetActive(true);
            StartCoroutine(stop());
        }
        if (collision.gameObject.tag == "msak")
        {
            shield.SetActive(true);
            Destroy(collision.gameObject);
            Invoke("shieldtime", 6);
        }
    }
    IEnumerator stop()
    {
        Debug.Log("stop");
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;
    }


    void shieldtime()
    {
        shield.SetActive(false);
    }
}
