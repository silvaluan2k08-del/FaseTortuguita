using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    [Header("Peças colocadas")]
=======
    public CharacterController characterController;
    [SerializeField] float speed = 5f;
    /*[Header("Peças colocadas")]
>>>>>>> 32b612ba32375b44bb201bba5ada92aeeb36a50f
=======
    [Header("Peças colocadas")]
>>>>>>> ea9e8195b8c1ebda81a95aa88586bf584e546fb0
    public bool corpoColocado;
    public bool cabecaColocada;
    public bool pataColocada;
    public bool pata1Colocada;
    public bool pernaColocada;
    public bool perna1Colocada;
<<<<<<< HEAD
<<<<<<< HEAD
    public CharacterController characterController;
    [SerializeField] float speed = 5f;
=======
>>>>>>> 32b612ba32375b44bb201bba5ada92aeeb36a50f
=======
    public CharacterController characterController;
    [SerializeField] float speed = 5f;
>>>>>>> ea9e8195b8c1ebda81a95aa88586bf584e546fb0

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger Enter: " + other.gameObject.name);
        switch (other.tag)
        {
            case "Corpo": corpoColocado = true; break;
            case "Cabeca": cabecaColocada = true; break;
            case "Pata": pataColocada = true; break;
            case "Pata1": pata1Colocada = true; break;
            case "Perna": pernaColocada = true; break;
            case "Perna1": perna1Colocada = true; break;
            default: return; // não é uma peça
        }
        
        Debug.Log("Peça " + other.tag + " coletada!");
        //Destroy(other.gameObject); // remove a peça solta

    }
<<<<<<< HEAD
<<<<<<< HEAD
=======
    */
>>>>>>> 32b612ba32375b44bb201bba5ada92aeeb36a50f
=======
>>>>>>> ea9e8195b8c1ebda81a95aa88586bf584e546fb0
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0f, z);
        movement = transform.TransformDirection(movement);
        characterController.Move(movement * speed * Time.deltaTime);
    }
    
}