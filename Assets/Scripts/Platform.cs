using UnityEngine;

public class Platform : MonoBehaviour
{
    private float growSpeed;
    private float scaleGrownX;

    private SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
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
            transform.localScale = Vector2.Lerp(transform.localScale , new Vector2(scaleGrownX , transform.localScale.y) , growSpeed * Time.deltaTime);
        }
        else
        {
            sr.color = new Color(1, 1, 1, sr.color.a - (0.2f * Time.deltaTime));
            if (sr.color.a <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
