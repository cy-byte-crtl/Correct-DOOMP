using UnityEngine;

public class shotpowerup : MonoBehaviour
{
    public float speed = 3;

    public GameObject powerupmultishot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (transform.position.y < -6)

        { Destroy(gameObject); }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("galga player"))

            Destroy(gameObject);



    }
}

