using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitMenu : MonoBehaviour
{
    private string word;
    public GameObject wordDisplay;

    public void OnEnable()
    {
        word = PlayerPrefs.GetString("word");
        victoryMessage();
    }   

    public void victoryMessage()
    {
        if(wordDisplay != null)
        {            
            wordDisplay.GetComponent<Text>().text = "Täydellistä, keräsit kaikki kirjaimet sanaan\n" + "~ " + word + " ~";
        }        
    }

    public void newGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void exitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
