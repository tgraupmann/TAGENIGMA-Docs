Word Detection
--------------

<img src="http://theylovegames.com/WordDetection.jpg"/>

Quick Links
-----------

<a target=_blank href="https://www.assetstore.unity3d.com/#/content/4518">[Word Detection]</a> is available in the Unity Asset Store.

<a target=_blank href="http://forum.unity3d.com/threads/152178-Word-Detection-Verbal-Commands">[Unity Showcase Thread]</a>


<a target=_blank href="http://theylovegames.com">[They Love Games]</a>


Feedback
--------

Please post your feedback and feature requests in the forums:

http://forum.unity3d.com/threads/152178-Word-Detection-Verbal-Commands


Audience
--------

Anyone wanting to quickly add spoken words to their game play. Add word profiles at runtime and immediately

start detecting spoken words.


Compatibility
-------------

This project is targeted for Unity 3.5.5 or better.

iOS and Android device support can vary.


Hardware testing
----------------

(Android)

Nexus 10

Samsung Galaxy S III

(iOS)

iPad 2nd Generation


What is in this package?
------------------------

This package includes a four example scenes in addition to the word detection package.


Example Scene 1 - Spectrum Mic, captures raw wave data from the microphone and performs

spectrum analysis which is rendered to a texture via the Graph Plotter.

Clicking on the example node in the scene reveals that the plot resolution can be altered

via a slider in the custom inspector.


Example Scene 2 - Array Copy, a tweak to the first example, capturing raw data from the

microphone is held in a circular array. This example reorders the array to keep the mic

position at the end of the array.


Example Scene 3 - Material Offset, rather than doing copy operations, this uses the material

texture offset to offset the mic position without needing to shift the array. The custom

inspector provides a toggle for normalizing the plot graph.


Example Scene 4 - Word Detection, words can be added at runtime which are detected and the

WordDetection's DetectedEvent fires each time the detected word changes. The detection

threshold can be tweaked via the custom inspector of WordDetection. Lower numbers are

more precise. Higher numbers are less precise.


Example Scene 5 - Verbal Control, words can control the transformation of a cube


Example Scene 6 - Push to talk in order to issue commands


Example Scene 7 - Mechanim example uses Word Detection to change states


Example Scene 8 - Adds saving and loading profiles to file with a dialog


Example Scene 9 - Adds word navigation using word sets


Example Scene 10 - Adds verbal commands that control facial expressions


Example Scene 11 - Verbal commands control another hi-resolution head


Example Scene 12 - Verbal command control a low-resolution talking head


Example Scene 13 - Verbal commands control another low-res talking head


Example Scene 14 - Verbal commands control blend shapes


Example Scene 15 - Verbal commands control emotional states


Example Scene 16 - Verbal commands control goat media clip playback


Example Scene 17 - Verbal commands drive Character Controller input


Tutorials
---------

You will find detailed tutorial videos on our YouTube channel: http://www.youtube.com/playlist?list=PLEXfnMfl8Yrvr7ynEqdgYXrKzuAH5wtyf playlist.


Notes
-----

1. Add Spectrum Microphone to the scene via the menu GameObject->Create Other->Audio->Create Spectrum Microphone.

2. Add Word Detection to the scene via the menu GameObject->Create Other->Audio->Add Word Detection.

3. Custom inspectors are available to tweak both Spectrum Microphone and Word Detection game objects.


Change Log
----------

1.0 - Added a realtime spectrum microphone. Added audio word detection.

1.1 - Added Example5 verbal control demo

1.2 - Rewrote FFT library

1.3 - Downgraded to Unity 3.5.0

1.4 - Added example 6

1.5 - Added support for profile loading and saving. Added an example toggle for "Use Plotter" which disables example texture rendering when off.

1.6 - Added push to talk example

1.7 - Added mechanim example

1.8 - Upgraded to Unity 4.5.1. Added file save dialog for word profiles, word set navigation, and the control of facial expressions with word commands

1.9 - Added goat media clips with playback ties with word detection

1.10 - Word Detection can now drive a Character Controller

1.11 - Upgraded to Unity 5.1.2. Truncated some data files to reduce the core package size. Example data files can be downloaded from: [WordDetection_GoatMediaClips.unitypackage](https://github.com/tgraupmann/TAGENIGMA-Docs/blob/master/Word-Detection/Data/WordDetection_GoatMediaClips.unitypackage)

Q & A
-----

You can send comments/questions to support@theylovegames.com where your feedback will help us create new tutorials and features in order to improve the product.

# Getting Started

1) Start with a new Scene.

2) Create a `GameObject` called `Spectrum Microphone` and attach the `Spectrum Microphone` script. The default capture time is `1 second` and the default sampling rate is `8192`. Adding `Spectrum Microphone` will also add an `Audio Source` component. This script allows recording from the microphone and playing back sample recordings.

![image-1](Word-Detection/image_1.png)

3) Create a `GameObject` called `Word Detection` and attach the `Word Detection` script. The default threshold is `60` and use push to talk is `off`. Drag the `Spectrum Microphone` from the Scene to the `Spectrum Microphone` field on the `Word Detection` script. This allows `Word Detection` to use the `Microphone` data.

![image-2](Word-Detection/image_2.png)

4) At a minimum you'll need a script that has a word detection callback. Create an `Example18` GameObject in the scene and attach the `Example18` script. You can use your own script and GameObject name as you follow along. Be sure to set the `_mWordDetection` field with a reference to the `WordDetection` object in the scene. This script adds the initial `Noise` profile for filtering out background noise. Word profiles also have to be initialized before they can be used in detection.

![image-3](Word-Detection/image_3.png)

```
using UnityEngine;

public class Example18 : MonoBehaviour
{
    /// <summary>
    /// Reference to the Word Detection object in the scene
    /// </summary>
    public WordDetection _mWordDetection = null;

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
        _mWordDetection.Words.Add(new WordDetails() { Label = "Noise" });

        //subscribe detection event
        _mWordDetection.WordDetectedEvent += WordDetectedHandler;
    }

    /// <summary>
    /// Callback for word detected event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WordDetectedHandler(object sender, WordDetection.WordEventArgs args)
    {
        if (string.IsNullOrEmpty(args.Details.Label))
        {
            return;
        }

        Debug.Log(string.Format("Detected: {0}", args.Details.Label));
    }
}
```

5) Expand the existing example to detect additional words. In the start event expand the set of words to detect.

```
    void Start()
    {
        if (null == _mWordDetection)
        {
            Debug.LogError("Missing meta reference to Word Detection");
            return;
        }

        // populate the word set

		// Background noise is the word profile we always want to ignore during detection
        _mWordDetection.Words.Add(new WordDetails() { Label = "Noise" });

		// Add a word to detect when saying "Go"
        _mWordDetection.Words.Add(new WordDetails() { Label = "Go" });

		// Add a word to detect when saying "Duck"
        _mWordDetection.Words.Add(new WordDetails() { Label = "Duck" });

		// Add a word to detect when saying "Left"
        _mWordDetection.Words.Add(new WordDetails() { Label = "Left" });

		// Add a word to detect when saying "Right"
        _mWordDetection.Words.Add(new WordDetails() { Label = "Right" });

        //subscribe detection event
        _mWordDetection.WordDetectedEvent += WordDetectedHandler;
    }
```

6) Add a helper function to retrieve the word profile given the label of the `WordDetails`.

```
    protected virtual WordDetails GetWord(string label)
    {
        foreach (WordDetails details in AudioWordDetection.Words)
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
```

7) The script needs access to the `SpectrumMicrophone` data so that recordings can be assigned to the word profiles. Be sure to drag the `SpectrumMicrophone` to the `_mSpectrumMicrophone` field on the `Example18` script.

```
public class Example18 : MonoBehaviour
{
    /// <summary>
    /// Reference to the spectrum microphone
    /// </summary>
    public SpectrumMicrophone _mSpectrumMicrophone = null;
}
```

8) The `WordDetails` profiles need to be set for the word detection event to start firing when those words are detected. 

# API

The word detection API provides a callback event for detected words.

```
        //subscribe detection event
        AudioWordDetection.WordDetectedEvent += WordDetectedHandler;
```

## Detected Word Score

The word detection system uses an event that fires when the word with the best score satisfies a match.

```
    /// <summary>
    /// Handle word detected event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WordDetectedHandler(object sender, WordDetection.WordEventArgs args)
    {
    }
```

The `WordEventArgs` argument has a public field that includes the name of the detected word `args.Details.Label`.

The `WordEventArgs` argument has a score that identifies the strength of the match (larger score indicates better match) `args.Details.Score`. 
