using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class RandomParticle : MonoBehaviour
{
    public float endvalue;
    public GameObject Capsule;
    public float Speed;
    public float AnimationTime;
    public float endScale;

    public List<GameObject> particles;


    public GameObject Confetti;
    private void Start()
    {

        Capsule.transform.DOMoveY(endvalue, AnimationTime).OnComplete(() =>
        {
            Capsule.transform.DOMoveZ(endvalue, AnimationTime).OnComplete(() =>
            {
                Capsule.transform.DOScale(endvalue, AnimationTime).OnComplete(() =>
                {
                    Capsule.transform.DOScale(new Vector3(0, 0, 0), AnimationTime);
                    GameObject createdConfetti = Instantiate(Confetti); 
                    createdConfetti.transform.position = Capsule.transform.position;
                    createdConfetti.SetActive(true);
                });
            });
        });
    }
}

