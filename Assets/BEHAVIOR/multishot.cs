using UnityEngine;

public class multishot : MonoBehaviour
{
    public float speed = 6;

    public GameObject multi_shot;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (transform.position.y < -6)
        { Destroy(gameObject); }
    }
}
