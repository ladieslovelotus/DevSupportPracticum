using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdManagerScript : MonoBehaviour {

    // Use this for initialization
    void Start() {

        // variable to capture what platform the application is running on
        int nPlatformID = 0;

        // check what platform we are running
        if (Application.platform == RuntimePlatform.Android)             // we are running on Android
            // set the Platform ID
            nPlatformID = 1082375;
        else if (Application.platform == RuntimePlatform.IPhonePlayer)   // we are running iPhone
            // set the Platform ID
            nPlatformID = 1082376;

        // check to see if the Advertisement system has been set up
        if(!Advertisement.isInitialized)
            // set up the Advertisement
            Advertisement.Initialize(nPlatformID.ToString(), true);
    }

    #region helper functions

    // function to display an ad when it is ready
    public void ShowAd()
    {
        // check to see if the advert is ready to show
        if (Advertisement.IsReady())
        {
            // display the advert to the player
            Advertisement.Show();
        }
    }

    #endregion
}
