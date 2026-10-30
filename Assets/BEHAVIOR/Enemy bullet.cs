using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    public float speed = 6;

    public GameObject bullet;
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
        {
            Destroy(gameObject);

        }
        }

    }


