using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class EnmeyTrigger : MonoBehaviour
{

    Enmies[] enmies;
    // Start is called before the first frame update
    void Awake()
    {
        //GameObject.FindGameObjectsWithTag("Shootable", );
        enmies = FindObjectsByType<Enmies>(FindObjectsInactive.Include, FindObjectsSortMode.None);

    }


    private void OnTriggerEnter(Collider Target)
    {
        if (Target.gameObject.tag == "Player")
        {
            Debug.Log("player Enter");
            var seq = DOTween.Sequence();
            foreach (Enmies enemy in enmies)
            {
                var pos = enemy.transform.position;
                pos.y = 4;
                seq.Append(enemy.transform.DOMove(pos, 5).SetEase(Ease.OutCubic));
                enemy.gameObject.SetActive(true);
            }

        }
    }


}
