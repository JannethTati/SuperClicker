using System;
using UnityEngine;

public class HandVRController : MonoBehaviour
{
    #region
    //Linea de la panatalla
    private LineRenderer _line;
    //Personaje que teletransportar
    [SerializeField] private Transform _player;

    [SerializeField] private GameObject _teleportMarc;

    //boton necesario para el teleport.
    [SerializeField] private OVRInput.Button _buttonPressed;
    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
        

    }
    private void Update()
    {
        TeleportRay();

        
    }

    private void TeleportRay()
    {
        _line.SetPosition(0, transform.position);

        RaycastHit hit;

        if (Physics.Raycast(transform.position + transform.right * 0.2f, transform.right, out hit))

        {
            if (hit.collider.tag == "Floor")
            {
                _line.SetPosition(1, hit.point);
                _teleportMarc.SetActive(true);
                _teleportMarc.transform.position = hit.point;

                if (OVRInput.GetDown(_buttonPressed) == true)
                    _player.position = hit.point + Vector3.up * 1.8f;

            }
            else
            {
                _teleportMarc.SetActive(false);

                _line.SetPosition(1, transform.position);
            }
        }
    }

    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   
}
