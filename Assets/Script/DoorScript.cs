using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator animator;
    public AudioSource EntryDoor1;
    public AudioSource EntryDoor2;

    // Start is called before the first frame update
    void Start()
    {
        //Assignation de son propre animator en tant que variable pour pouvoir y accéder plus simplement
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //déclence l'animation d'ouverture des portes
    //Y intégrer le jeu d'un son ? Le lancement d'une corroutine ?
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("In", true);
        EntryDoor1.Play();
    }

    //déclence l'animation de fermeture des portes
    //Y intégrer le jeu d'un son ? Le lancement d'une corroutine ?
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("In", false);
        EntryDoor2.Play();
    }

    //Créer une fonction publique à appeler lors d'un animation event ?

}
