using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Projectile : MonoBehaviour
{

    public float speedval = 6;
    public int points = 100;

    // Update is called once per frame
    void Update()

    {

        transform.Translate(-transform.right * speedval * Time.deltaTime);

        if (transform.position.x < -10)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.name == "Bat")

            Destroy(gameObject);
    }




}


