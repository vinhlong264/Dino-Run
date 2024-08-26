using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject PlatFormPrefabs;
    [SerializeField] private float growSpeed;
    [SerializeField] private float scaleGrownX;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 PosMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject currentPlatform = Instantiate(PlatFormPrefabs , new Vector3(PosMouse.x , PosMouse.y , 1) , Quaternion.identity);
            Platform platformScript = currentPlatform.GetComponent<Platform>();
            if(platformScript != null)
            {
                platformScript.SetUpPlatForm(growSpeed, scaleGrownX);   
            }
        }
    }
}
