using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    private string gameId = "5717097";
    private string placementId = "Interstitial_Android"; // Set this to your actual placement ID from the dashboard
    private bool testMode = true;

    void Start()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
        Advertisement.Initialize(gameId, testMode, this);
    }

    public void LoadAd()
    {
        Advertisement.Load(placementId, this);
    }

    public void ShowAd()
    {
        Advertisement.Show(placementId, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads Initialization Complete");
        LoadAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Ad successfully loaded.");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Failed to load Ad: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Failed to show Ad: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Showing Ad");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Ad clicked");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Ad finished showing");
        // Call Restart Game here if necessary
        RestartGame();
    }

    public void RestartGame()
    {
        // Implement your game restart logic here
        Debug.Log("Game restarted");
        // Load a new ad for the next round
        LoadAd();
    }
}
