using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NavManager : MonoBehaviour
{
    public Canvas clickerCanvas;
    public Canvas upgradeCanvas;
    public Canvas idlerCanvas;
    
    public void Click_ToClicker() {
        clickerCanvas.enabled = true;
        upgradeCanvas.enabled = false;
        idlerCanvas.enabled = false;
    
    }
    public void Click_ToUpgrade() {
        clickerCanvas.enabled = false;
        upgradeCanvas.enabled = true;
        idlerCanvas.enabled = false;
    }
    public void Click_ToIdler() {
        clickerCanvas.enabled = false;
        upgradeCanvas.enabled = false;
        idlerCanvas.enabled = true;
    }

}
