using UnityEngine;
using System;
using TMPro;

public class MobileController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private TextMeshProUGUI _testText;
    private float _initialTime;
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();

        if (Input.touchCount > 0)
        {
            //Moving Touch
            if (Input.GetTouch(0).phase == TouchPhase.Began)
                _initialTime = Time.realtimeSinceStartup;

            //Moving Touch
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
                _testText.text = "Moving";

            //Stationary Touch
            if (Input.GetTouch(0).phase == TouchPhase.Stationary)
                _testText.text = "Stationary";

            //Al levantar el dedo: Mostramos la posición
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                float finalTime = Time.realtimeSinceStartup - _initialTime;
                _testText.text = Input.GetTouch(0).position.ToString() + "\n" + finalTime;

            }
        }


    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion
}
