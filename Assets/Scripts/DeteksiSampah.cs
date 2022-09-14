using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource mediaPlayerBenar;
    private AudioSource mediaPlayerSalah;
    public TextMeshProUGUI textScore;
    // Start is called before the first frame update
    void Start()
    {
        mediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        mediaPlayerBenar.clip = audioBenar;

        mediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        mediaPlayerSalah.clip = audioSalah;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(nameTag))
        {
            Data.score += 25;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            mediaPlayerBenar.Play();
        }
        else
        {
            Data.score -= 25;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            mediaPlayerSalah.Play();
        }
    }
}
