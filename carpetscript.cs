using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpetscript : MonoBehaviour
{

    public CanvasGroup carpetPopup;

    // Start is called before the first frame update
    void Start()
    {
        //UI element is set to be fully transparent
        carpetPopup.alpha = 0f;
        StartCoroutine(Popin());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator Popin()
    {
        //73 seconds pass to time with the music, then UI element is set to be visible again.
        yield return new WaitForSeconds(73);
        carpetPopup.alpha = 1f;
        //second coroutine is called
        StartCoroutine(Popout());
    }
    private IEnumerator Popout()
    {
        //4 seconds pass, then the UI element is set to be transparent again.
        yield return new WaitForSeconds(4);
        carpetPopup.alpha = 0f;
    }
    }
