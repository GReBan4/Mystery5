using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPresenter : MonoBehaviour
{
    //BGM
    [SerializeField] Text bgmVolumeText; // BGMMenuViewのvolumeTextを取得
    [SerializeField] Slider bgmSlider; // BGMMenuViewのsliderを取得

    // Start is called before the first frame update
    void Start()
    {
        // BGMを再生
        AudioManager.GetInstance().PlayBGM(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // BGMMenuViewのSliderを動かしたときに呼び出す
    public void OnChangedBGMSlider()
    {
        // Sliderの値に応じてBGMを変更
        AudioManager.GetInstance().BGMVolume = bgmSlider.value;
        // volumeTextの値をSliderのvalueに変更
        bgmVolumeText.text = string.Format("{0:0}", bgmSlider.value * 100);
    }
}
