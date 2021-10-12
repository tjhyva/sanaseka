using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Apukirjaimet
    private char[] alfabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Å', 'Ö' };
    //Kirjain prefabit
    public GameObject[] letters;
    //Kirjain prefabit
    public GameObject[] lettersBlank;
    //Syötetty sana
    private string word;
    //Laskuri
    private static int counter = 3;

    //Haetaan syötetty sana
    public void OnEnable()
    {
        word = PlayerPrefs.GetString("word");
    }  
    void Start()
    {
        spawnObject();
    }

    //Kirjainten spawni
    public void spawnObject()
    {
        char[] wordParse = word.ToUpper().ToCharArray();
        foreach (char letter in wordParse)
        {
            for (int i = 0; i < alfabet.Length; i++)

                if (alfabet[i] == letter)
                {
                    float screenRatio = (float)Screen.width / (float)Screen.height;
                    float widthOrtho = Camera.main.orthographicSize * screenRatio;

                    Vector3 emptyLetterPosition = new Vector3(-widthOrtho + counter, Camera.main.orthographicSize - 7.4f);
                    Instantiate(lettersBlank[i], emptyLetterPosition, Quaternion.identity);
                    
                    Vector3 letterPosition = new Vector3(Random.Range(-widthOrtho + 8.7f, widthOrtho - 2.7f), Random.Range(-Camera.main.orthographicSize + 2.7f, Camera.main.orthographicSize - 13.7f), 0f);                    
                    Instantiate(letters[i], letterPosition, Quaternion.identity);                                    
                    
                    counter += 4;
                }
        }
        counter = 3;
    }
}
