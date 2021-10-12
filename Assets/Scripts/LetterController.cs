using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterController : MonoBehaviour
{
    //Syötetty sana
    private string word;
    //laskuri
    private static int counter;
    //Apu kirjain
    private char letter;

    public AudioClip collectedClip;

    //haetaan muuttujia
    public void OnEnable()
    {
        word = PlayerPrefs.GetString("word");
        counter = PlayerPrefs.GetInt("counter");
    }

    void OnTriggerEnter2D(Collider2D other)
    {        
        RocketController controller = other.GetComponent<RocketController>();
        char[] wordParse = word.ToLower().ToCharArray();
        letter = wordParse[counter];
    
        if(letter + "(Clone)" == gameObject.name)
        {            
            counter++;
            Destroy(gameObject);
            controller.PlaySound(collectedClip);

            if (counter == wordParse.Length)
            {
                counter = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);                            
            }                        
        }
    }
}
