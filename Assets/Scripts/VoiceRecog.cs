using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

public class VoiceRecog : MonoBehaviour
{
    [SerializeField]
    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;
    public GameObject Cube;
    public GameObject Sphere;

    void Start()
    {
        m_Keywords = new string[2];
        m_Keywords[0] = "Create A Cube";
        m_Keywords[1] = "Load Next Level";
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        float newX = UnityEngine.Random.Range(-3, 3);
        float newZ = UnityEngine.Random.Range(-3, 3);

        if (args.text == m_Keywords[0])
        {
            Instantiate(Cube, new Vector3(newX, newZ, 1), Quaternion.identity);
        }

        if (args.text == m_Keywords[1])
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
