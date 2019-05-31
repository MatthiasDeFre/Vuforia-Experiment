using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomTracking : DefaultTrackableEventHandler
{
    public Text Text;
   protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Text.text = this.name;
    }
}
