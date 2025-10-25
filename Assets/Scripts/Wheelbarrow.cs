using UnityEngine;

public class Wheelbarrow : MonoBehaviour
{
    public int appleCount;
    public Animator anim;
    public GameManager gameManager;
    public float countdown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        appleCount = 0;
        anim = GetComponent<Animator>();
        countdown = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetInteger("appleAmount", appleCount);
        countdown -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Apple" && appleCount < 10 && collision.GetComponent<Apple>().canCollect == true)
        {
            //Debug.Log("APPLE");
            appleCount++;
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Apple" && appleCount >= 10 )
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Drop Off" && countdown <= 0 && appleCount > 0)
        {
            //Debug.Log("Sanes");
            gameManager.IncreaseScore(1);
            appleCount--;
            countdown = 0.3f;
        }
    }
}
