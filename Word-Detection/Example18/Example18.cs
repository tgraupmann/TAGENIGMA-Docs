using UnityEngine;
using UnityWordDetection;

public class Example18 : MonoBehaviour
{
    /// <summary>
    /// Reference to the Word Detection object in the scene
    /// </summary>
    public WordDetection _mWordDetection = null;

    /// <summary>
    /// Reference to the spectrum microphone
    /// </summary>
    public SpectrumMicrophone _mSpectrumMicrophone = null;

    /// <summary>
    /// Indicates a profile is being recorded
    /// </summary>
    private string _mRecordingProfile = string.Empty;

    /// <summary>
    /// Show the last detected word
    /// </summary>
    private string _mLastDetectedWord = string.Empty;

    /// <summary>
    /// Holds a copy of the microphone data
    /// </summary>
    private float[] _mMicrophoneData = null;

    /// <summary>
    /// Word constants
    /// </summary>
    private const string WORD_NOISE = "Noise";
    private const string WORD_GO = "Go";
    private const string WORD_DUCK = "Duck";
    private const string WORD_LEFT = "Left";
    private const string WORD_RIGHT = "Right";

    /// <summary>
    /// Create initial word set and subscribe to the word detection callback
    /// </summary>
    void Start()
    {
        if (null == _mWordDetection)
        {
            Debug.LogError("Missing meta reference to Word Detection");
            return;
        }

        // populate the word set

        // Background noise is the word profile we always want to ignore during detection
        _mWordDetection.Words.Add(new WordDetails() { Label = WORD_NOISE });

        // Add a word to detect when saying "Go"
        _mWordDetection.Words.Add(new WordDetails() { Label = WORD_GO });

        // Add a word to detect when saying "Duck"
        _mWordDetection.Words.Add(new WordDetails() { Label = WORD_DUCK });

        // Add a word to detect when saying "Left"
        _mWordDetection.Words.Add(new WordDetails() { Label = WORD_LEFT });

        // Add a word to detect when saying "Right"
        _mWordDetection.Words.Add(new WordDetails() { Label = WORD_RIGHT });

        //subscribe detection event
        _mWordDetection.WordDetectedEvent += WordDetectedHandler;
    }

    /// <summary>
    /// Get a word profile by string label
    /// </summary>
    /// <param name="label"></param>
    /// <returns></returns>
    private WordDetails GetWord(string label)
    {
        foreach (WordDetails details in _mWordDetection.Words)
        {
            if (null == details)
            {
                continue;
            }
            if (details.Label.Equals(label))
            {
                return details;
            }
        }

        return null;
    }

    /// <summary>
    /// Callback for word detected event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void WordDetectedHandler(object sender, WordDetection.WordEventArgs args)
    {
        if (!string.IsNullOrEmpty(_mRecordingProfile))
        {
            return;
        }

        if (string.IsNullOrEmpty(args.Details.Label))
        {
            return;
        }

        _mLastDetectedWord = args.Details.Label;
    }

    /// <summary>
    /// Get the microphone data from the spectrum microphone
    /// </summary>
    /// <returns></returns>
    private void FetchMicrophoneData()
    {
        int position = _mSpectrumMicrophone.GetPosition();
        int size = _mSpectrumMicrophone.CaptureTime * _mSpectrumMicrophone.SampleRate;
        float[] data = _mSpectrumMicrophone.GetData(0);

        if (null == _mMicrophoneData ||
            _mMicrophoneData.Length != size)
        {
            _mMicrophoneData = new float[size];
        }

        //shift array
        for (int index = 0, i = position; index < size; ++index, i = (i + 1) % size)
        {
            _mMicrophoneData[index] = data[i];
        }
    }

    /// <summary>
    /// Setup the profile spectrum data
    /// </summary>
    /// <param name="details"></param>
    private void SetupProfile(WordDetails details)
    {
        _mWordDetection.LoadWord(_mMicrophoneData, 1, _mSpectrumMicrophone.SampleRate, details);
    }

    /// <summary>
    /// Play back the audio clip of a word profile
    /// </summary>
    /// <param name="details"></param>
    private void PlayProfile(WordDetails details)
    {
        //play the audio
        if (null == details.Audio)
        {
            details.Audio = AudioClip.Create(string.Empty, details.Wave.Length, 1, _mSpectrumMicrophone.SampleRate, false);
        }
        details.Audio.SetData(details.Wave, 0);
        _mSpectrumMicrophone.GetComponent<AudioSource>().loop = false;
        _mSpectrumMicrophone.GetComponent<AudioSource>().mute = false;
        _mSpectrumMicrophone.GetComponent<AudioSource>().PlayOneShot(details.Audio);
    }

    /// <summary>
    /// Create a push to talk button that creates a word profile
    /// </summary>
    /// <param name="buttonLabel"></param>
    /// <param name="wordLabel"></param>
    /// <param name="currentEvent"></param>
    private void ShowButtonSetProfile(string buttonLabel, string wordLabel, Event currentEvent)
    {
        GUILayout.BeginHorizontal();
        GUILayout.Button(buttonLabel);
        if (null != currentEvent)
        {
            Rect rect = GUILayoutUtility.GetLastRect();
            bool overButton = rect.Contains(currentEvent.mousePosition);
            if (Input.GetMouseButton(0))
            {
                if (overButton)
                {
                    _mRecordingProfile = wordLabel;
                }
            }
            else
            {
                if (_mRecordingProfile == wordLabel)
                {
                    WordDetails details = GetWord(_mRecordingProfile);
                    if (null != details)
                    {
                        details.Wave = _mMicrophoneData;
                        SetupProfile(details);
                        PlayProfile(details);
                        _mSpectrumMicrophone.ClearData();
                    }
                    _mRecordingProfile = string.Empty;
                }
            }
        }
        GUILayout.Label(string.Format("Score: {0}", GetWord(wordLabel).Score));
        GUILayout.EndHorizontal();
    }

    /// <summary>
    /// Fetch the microphone data for the next update frame
    /// </summary>
    void Update()
    {
        FetchMicrophoneData();
    }

    /// <summary>
    /// Show the available Microphones to select from
    /// </summary>
    private void ShowMicrophoneSelector()
    {
        GUILayout.Label(string.Format("Select a microphone: count={0}", Microphone.devices.Length));

        int i = 0;
        foreach (string device in Microphone.devices)
        {
            string deviceName = device;
            string displayName = device;
            if (string.IsNullOrEmpty(displayName))
            {
                displayName = "Unknown";
            }

            displayName = string.Format("{0} {1}", i, displayName);

            if (GUILayout.Button(displayName, GUILayout.Height(60)))
            {
                WordDetectionMicrophone wordDetectionMicrophone = new WordDetectionMicrophone();
                wordDetectionMicrophone._mDeviceName = device;
                wordDetectionMicrophone._mDisplayName = displayName;
                _mSpectrumMicrophone._mWordDetectionMicrophone = wordDetectionMicrophone;
            }
            ++i;
        }
    }

    /// <summary>
    /// Display event
    /// </summary>
    void OnGUI()
    {
        if (null == _mSpectrumMicrophone._mWordDetectionMicrophone)
        {
            ShowMicrophoneSelector();
            return;
        }

        // Get the current event to know when buttons are held
        Event currentEvent = Event.current;

        // Show the last detected word in a label
        GUILayout.Label(string.Format("Last Detected Word: {0}", _mLastDetectedWord));

        foreach (WordDetails details in _mWordDetection.Words)
        {
            ShowButtonSetProfile(string.Format("Set `{0}` Profile", details.Label), details.Label, currentEvent);
        }
        
        GUILayout.Label(string.Format("Recording Profile: {0}", _mRecordingProfile));
    }
}
