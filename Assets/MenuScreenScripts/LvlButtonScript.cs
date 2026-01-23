using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LvlButtonScript : MonoBehaviour
{
    public TextMeshProUGUI buttonTMG;
    public int buttonText;
    public menuManagerScript menuManager;   
    void Start()
    {
        buttonTMG.text = buttonText.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGamePlay()
    {
        menuManager.level = buttonText - 1;
        SceneManager.LoadScene("GameplayScene");
    }
}
