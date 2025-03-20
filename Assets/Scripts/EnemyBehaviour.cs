using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform playerTransform;
    public float speed;
    public float dyingDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = FindAnyObjectByType<PlayerBehaviour>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPlayer = playerTransform.position - transform.position;
        directionToPlayer.Normalize();

        transform.position = transform.position + directionToPlayer * speed * Time.deltaTime;

        if (Vector3.Distance(playerTransform.position, transform.position) < dyingDistance)
        {
            Destroy(gameObject);
        }
    }
}
