using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 50.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject explosion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > screenBounds.x * -2)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

    }


}
