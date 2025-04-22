using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
        [SerializeField] private TextMeshProUGUI _textTemps;
        // private float _tempMax = 10;
        [SerializeField] private float _tempsEcoule;
        [SerializeField] private Image _image;
    void Start()
    {
        _tempsEcoule=10;
    }

    // Update is called once per frame
    void Update()
    {
        Decompte();
    }
    void Decompte()
        {
            if(_tempsEcoule>=0 & _tempsEcoule<=10){

                _tempsEcoule += Time.deltaTime*-1;

                int _minutes = Mathf.FloorToInt(_tempsEcoule / 60);
                _textTemps.text = _minutes.ToString();

                int _secondes = Mathf.FloorToInt(_tempsEcoule % 60);
                // _textTemps.text = _minutes.ToString
                _textTemps.text = string.Format("{0:00}:{1:00}", _minutes, _secondes);
                _image.fillAmount += 0.025f;
            }

            else if(_tempsEcoule<0){
                Debug.Log("gdj");
            }
        }

    

}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;
// using UnityEngine.UI;

// public class Timer : MonoBehaviour
// {
//     public float timeRemaining = 60; // Set the initial time to 60 seconds
//     [SerializeField] private TextMeshProUGUI _textTemps; // Reference to the UI Text component

//     void Update()
//     {
//         if (timeRemaining > 0)
//         {
//             timeRemaining -= Time.deltaTime;

//             float minutes = Mathf.FloorToInt(timeRemaining / 60);
//             float seconds = Mathf.FloorToInt(timeRemaining % 60);

//             _textTemps.text = string.Format("{0:00}:{1:00}", minutes, seconds);
//         }
//     }
// }