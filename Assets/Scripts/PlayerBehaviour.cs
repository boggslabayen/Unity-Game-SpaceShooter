using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    // public Transform player;
    public float speed = 5.0f;
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Started hello world");
    }

    // Update is called once per frame
    void Update()
    {
        float inputValue = Input.GetAxis("Horizontal");
        float yValue = Input.GetAxis("Vertical");
        Debug.Log("My Horizontal input is ->" + inputValue);

        transform.position = new Vector3(transform.position.x + inputValue * speed * Time.deltaTime, transform.position.y + yValue * speed * Time.deltaTime, transform.position.z);
        if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }

    }

    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = transform.position;
    }
}
