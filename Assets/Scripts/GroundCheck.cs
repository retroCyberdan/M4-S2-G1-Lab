using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private float _maxDistance = 0.1f;

    public bool IsGrounded {  get; private set; } // <- creo una booleana per controllare se tocco il terreno, accessibile in lettura ma non in scrittura

    private void OnDrawGizmos()
    { 
        // definisco il colore della linea che disegnerò con DrawLine()
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position - Vector3.up * _maxDistance);
    }

    // Update is called once per frame
    void Update()
    {
        // tramite Raycast effettuo un controllo ambientale, il cui esito mi richioamerò in altri metodi
        IsGrounded = Physics.Raycast(transform.position, -Vector3.up, _maxDistance);
    }
}
