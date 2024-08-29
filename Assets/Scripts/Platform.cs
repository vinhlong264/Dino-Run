using UnityEngine;

public class Platform : MonoBehaviour
{
    private float growSpeed;
    private float scaleGrownX;

    private SpriteRenderer sr;
    private BoxCollider2D box;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    public void SetUpPlatForm(float _grownSpeed , float _scaleGrowX)
    {
        growSpeed = _grownSpeed;
        scaleGrownX = _scaleGrowX;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            box.size = Vector2.Lerp(box.size, new Vector2(scaleGrownX, box.size.y), growSpeed * Time.deltaTime);
            sr.size  = Vector2.Lerp(sr.size, new Vector2(scaleGrownX, sr.size.y), growSpeed * Time.deltaTime);
        }
        else
        {
            sr.color = new Color(1, 1, 1, sr.color.a - (0.15f * Time.deltaTime));
            if (sr.color.a <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
