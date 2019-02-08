using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManmeger : MonoBehaviour
{

    private static BgmManmeger _instance = null;

    public static BgmManmeger Instance { get { return _instance; } }
    public AudioSource MenuSound;
    public AudioSource InGameSound;
    public AudioSource WalkSound;
    public AudioSource AttackSound;
    public AudioSource AtionSound;

    // Start is called before the first frame update
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        MenuSound.volume = PlayerPrefs.GetInt("Menusoundvolume");
        InGameSound.volume = PlayerPrefs.GetInt("InGameSoundvolume");
        WalkSound.volume= PlayerPrefs.GetInt("InGameSoundvolume"); 
        AttackSound.volume= PlayerPrefs.GetInt("InGameSoundvolume");
        AtionSound.volume= PlayerPrefs.GetInt("InGameSoundvolume");
    }
}
