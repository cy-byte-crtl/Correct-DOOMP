using TMPro;
using UnityEngine;

public class ship : MonoBehaviour
{
    public float speed = 4;
    private int scoreVal = 0;

    public TextMeshProUGUI scoreBox;

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
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 7, 7), Mathf.Clamp(transform.position.y, -4, 4), 0);
    }






