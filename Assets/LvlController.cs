using UnityEngine;
using UnityEngine.UI;

public class LvlController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int lvl = 0;
    public GameObject tryAgain;
    public GameObject changeLvl;
    public GameObject youLose;
    public bool gamePause = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameLost()
    {
        gamePause = true;
        tryAgain.SetActive(true);
        changeLvl.SetActive(true);
        youLose.SetActive(true);

    }

    public void broadCastReset()
    {
        gamePause = false;
        tryAgain.SetActive(false);
        changeLvl.SetActive(false);
        youLose.SetActive(false);
        gameObject.BroadcastMessage("resetLevel", lvl);
    }
}
