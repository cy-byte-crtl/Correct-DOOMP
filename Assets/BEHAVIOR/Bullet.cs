using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Bullet : MonoBehaviour
{

    public float speedval = 5;
    public int points = 100;

    // Update is called once per frame
    void Update()

    {

        transform.Translate(transform.up * speedval * Time.deltaTime);

        {
            if (transform.position.y > 6)
                Destroy(gameObject);
        }
    }

}


