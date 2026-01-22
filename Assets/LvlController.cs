using UnityEngine;

public class LvlController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int lvl = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void broadCastReset()
    {
        gameObject.BroadcastMessage("resetLevel", lvl);
    }
}
