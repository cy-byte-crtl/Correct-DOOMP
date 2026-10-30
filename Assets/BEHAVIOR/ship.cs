using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Ship : MonoBehaviour
{
    public float speed = 4;
   

    public Image[] lives;

    public int lifecount = 3;

    public GameObject Bullet;

    public GameObject multi_shot;

    private bool hasMultishot = false;

    public float hasMultishotTimer = 0, hasMultishotWait = 5;


    // Update is called once per frame
    void Update()
    {
        // traveling up 

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7, 7), Mathf.Clamp(transform.position.y, -4, 4), 0);

        if (Input.GetKeyUp(KeyCode.Space))

        {
            if (!hasMultishot)
                Instantiate(Bullet, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
            else
                Instantiate(multi_shot, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
        }

        hasMultishotTimer += Time.deltaTime;

        if (hasMultishotTimer > hasMultishotWait)
        {

            hasMultishotTimer = 0;
            hasMultishot = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            lifecount -= 1;
            if (lifecount <= 0)
            {
                lifecount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }


            lives[lifecount].enabled = false;
        }
            if (collision.gameObject.CompareTag("Multi")) 

            {
                hasMultishot = true;



            }



        
    }
  
    

}






