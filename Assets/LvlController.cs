using UnityEngine;
using UnityEngine.UI;

public class LvlController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int lvl;
    public GameObject tryAgain;
    public GameObject changeLvl;
    public GameObject youLose;
    public GameObject youWin;
    public PlayerController player;
    public bool gamePause = false;

    //private GameObject menuManager;
    void Start()
    {
        if (menuManagerScript.Instance != null)
        {
            Debug.Log("found menuManager");
            lvl = menuManagerScript.Instance.level;
        }
        else lvl = 0;
        Debug.Log("found menuManager");
        broadCastReset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameLost()
    {
        if (gamePause == false)
        {
            gamePause = true;
            tryAgain.SetActive(true);
            changeLvl.SetActive(true);
            youLose.SetActive(true);
            player.stopPlayer = true;
        }
    }
    public void gameWon()
    {
        gamePause = true;
        tryAgain.SetActive(true);
        changeLvl.SetActive(true);
        youWin.SetActive(true);
        player.stopPlayer = true;
    }

    public void broadCastReset()
    {
        gamePause = false;
        tryAgain.SetActive(false);
        changeLvl.SetActive(false);
        youLose.SetActive(false);
        youWin.SetActive(false);
        gameObject.BroadcastMessage("resetLevel", menuManagerScript.Instance.level);
        gameObject.BroadcastMessage("resetCounter", menuManagerScript.Instance.level);
        gameObject.BroadcastMessage("resetGround", menuManagerScript.Instance.level);
    }
}
