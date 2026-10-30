using UnityEngine;

public class backgroundscroller : MonoBehaviour
{
    public float speed = 6;

    public float var1 = -5;

    public float var2 = 14.4f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if (transform.position.y < var1)
        {
            transform.position = new Vector3(transform.position.x, var2, transform.position.z);
        }

    }
}
