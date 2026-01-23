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

    //private GameObject menuManager;
    void Start()
    {
        lvl = menuManagerScript.Instance.level;
        //if (menuManager != null && menuManager.TryGetComponent<menuManagerScript>(out menuManagerScript menuManagerScriptt))
        //{
        //    lvl = menuManagerScriptt.level;
        //}
        broadCastReset();
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
        gameObject.BroadcastMessage("resetCounter", lvl);
        //gameObject.BroadcastMessage("resetGround", lvl);
    }
}
