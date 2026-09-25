using UnityEditor.ShaderKeywordFilter;
using UnityEditor.Timeline;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 4;
    // Update is called once per frame
    void Update()
    {
        // traveling up 
        {
            if (Input.GetKey(KeyCode.W)) 
                transform.Translate(transform.up * speed * Time.deltaTime);
        }
        {
            if (Input.GetKey(KeyCode.S))
                transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        {
            if (Input.GetKey(KeyCode.D))
                transform.Translate(transform.right * speed * Time.deltaTime);
        }
        {
            if (Input.GetKey(KeyCode.A))
                transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.5f, 3.5f),
        transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bat")

            Destroy(gameObject);
    }
}
