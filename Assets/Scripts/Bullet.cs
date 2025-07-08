using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * Time.deltaTime * 5, Space.World);
    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion
}
