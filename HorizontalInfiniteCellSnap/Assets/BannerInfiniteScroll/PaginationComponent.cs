using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class PaginationComponent : MonoBehaviour
{
    public HorizontalScrollSnap mHorizonatlScrollComp;

    [SerializeField]
    private Image[] mPageIndicators;

    // Start is called before the first frame update
    void Start()
    {
        mHorizonatlScrollComp.OnSelectionChangeEndEvent.AddListener(OnPageChanged);

        OnPageChanged(0);
    }

    // Update is called once per frame
    void OnPageChanged(int inPage)
    {
        Debug.Log("Page " + inPage);

        for(int i=0;i<mPageIndicators.Length;i++)
        {
            if((inPage) == i)
            {
                mPageIndicators[i].color = Color.black;
            }
            else
            {
                mPageIndicators[i].color = Color.white;
            }
        }
    }
}
