using UnityEngine;

public class RocketController : MonoBehaviour
{
    //Raketin maksimin nopeus ja pyörimisnopeus
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;
    
    //Raketin koko
    float rocketBoundaryRadius = 3f;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //raketin suunta       
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;        
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0, z);
        transform.rotation = rot;

        //raketin liike
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        pos += rot * velocity;

        if(pos.y+rocketBoundaryRadius > Camera.main.orthographicSize -10)
        {
            pos.y = Camera.main.orthographicSize-rocketBoundaryRadius - 10;
        }
        if (pos.y - rocketBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + rocketBoundaryRadius;
        }
        if (pos.x + rocketBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - rocketBoundaryRadius;
        }
        if (pos.x - rocketBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + rocketBoundaryRadius;
        }        
        transform.position = pos;        
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
