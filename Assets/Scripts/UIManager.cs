using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public AudioMixer mixer;
    public GameManager manager;
    public Text scoreText; 
    public Text highscoreText;
    public float sliderValue;
    public float currentVolume;
    public int cscore = 0;
    public int highscore = 0;

    private void Start()
    { //Skor sistemleri ve di�er sistemlerin ba�lang�c�n�n datas� falan filan.
      //K�sacas� sahne ge�i�lerinde high score kaybolmamas�n� halletti�imiz yer.
        cscore = PlayerPrefs.GetInt("cscore", 0);
        highscore = PlayerPrefs.GetInt("highscore", 0);
        sliderValue = PlayerPrefs.GetFloat("volume");
        scoreText.text = cscore.ToString() + "";
        highscoreText.text = "" + highscore.ToString();
    }
    public void FullscreenToggle() { Screen.fullScreen = !Screen.fullScreen; } //Tam Ekran yapma kodu.
    public void SetVolume(float sliderValue)
    { //Ses seviyesini ayarlama ve kaydetmeye yard�mc� kod.
        mixer.SetFloat("AudioVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("volume", sliderValue);
    }
    public void PlayButton() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        PlayerPrefs.SetInt("cscore", 0);
        PlayerPrefs.SetInt("meatAteNumber", 0);
    }
    public void BackToMenuButton() { Time.timeScale = 1; SceneManager.LoadScene("Menu"); }
    public void QuitButton() { Application.Quit(); } //Oyunu kapat�o :d
}
