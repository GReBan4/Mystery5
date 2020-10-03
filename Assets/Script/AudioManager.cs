using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip[] bgmList; // BGMを読み込む
    [SerializeField] AudioSource audioSourceBGM; // BGMの音量を調整するために読み込む

    // BGMのボリュームを調整する関数
    public float BGMVolume
    {
        // audioSourceBGMのVolumeをいじることで調整
        get { return audioSourceBGM.volume; }
        set { audioSourceBGM.volume = value; }
    }

    // SceneをまたいでもObjectが破壊されないようにする
    static AudioManager Instance = null;

    public static AudioManager GetInstance()
    {
        if (Instance == null)
        {
            Instance = FindObjectOfType<AudioManager>();
        }
        return Instance;
    }

    private void Awake()
    {
        if (this != GetInstance())
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // BGMを再生する関数
    public void PlayBGM(int index)
    {
        audioSourceBGM.clip = bgmList[index];
        audioSourceBGM.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
