using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Syötetty sana
    private string word;
    //Laskuri
    private int counter = 0;
    //Virhekirjoitus boxi
    public GameObject wordDisplay;

    private string victoryText = "moi";

    //haetaan sana input kentästä
    public void getText(string s) 
    {
        word = s;
    }
    //Tallennetaan muuttujat myöhempään käyttöön
    private void OnDisable()
    {        
        getText(word);
        PlayerPrefs.SetString("word", word);
        PlayerPrefs.SetInt("counter", counter);
        PlayerPrefs.SetString("victoryText", victoryText);
    }
    //Play buttonin ohjaus
    public void PlayGame()
    {        
        if (word == null)
        {
            wordDisplay.GetComponent<Text>().text = "Unohditko kirjoittaa sanasi";            
        }
        else if (word.Length >= 18)
        {
            wordDisplay.GetComponent<Text>().text = "Sana on liian pitkä, max 17 kirjainta";
        }
        else
        {            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
    //Exit buttonin ohjaus
    public void doExitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void newGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
