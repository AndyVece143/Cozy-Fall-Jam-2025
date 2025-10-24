using UnityEngine;

public class Apple : MonoBehaviour
{
    public float timer;
    public int appleState = 0;
    public Animator anim;
    private Rigidbody2D body;
    private BoxCollider2D boxCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = Random.Range(1, 5);
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && appleState < 3)
        {
            timer = Random.Range(1, 5);
            if (appleState == 0)
            {
                anim.SetTrigger("growing1");
            }
            if (appleState == 1)
            {
                anim.SetTrigger("growing2");
            }
            if (appleState == 2)
            {
                anim.SetTrigger("growing3");
            }
            appleState++;
        }

        if (timer <= 0 && appleState == 3)
        {
            body.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
