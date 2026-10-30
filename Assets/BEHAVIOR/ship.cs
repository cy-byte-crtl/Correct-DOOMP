using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Ship : MonoBehaviour
{
    public float speed = 4;
    private int scoreVal = 0;

    public Image[] lives;

    public GameObject Bullet;

    public TextMeshProUGUI scoreBox;

    // Update is called once per frame
    void Update()
    {
        // traveling up 

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7, 7), Mathf.Clamp(transform.position.y, -4, 4), 0);

        if (Input.GetKeyUp(KeyCode.Space))

        {
            Instantiate(Bullet, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
        }

    }
          private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("enemy")) ;
    }
  
    

}






