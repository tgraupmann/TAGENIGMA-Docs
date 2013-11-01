Scene Merge
-----------

<img src="http://theylovegames.com/SceneMerge.jpg"/>

**Quick Links**

<a target=_blank href="https://www.assetstore.unity3d.com/#/content/5412">[Scene Merge]</a> is available in the Unity Asset Store.

<a target=_blank href="http://forum.unity3d.com/threads/159118-Scene-Diff-Ease-Your-Suffering">[Unity Showcase Thread]</a>


Audience
--------

Anyone looking to have a better experience merging scenes.


Compatibility
-------------

This project is targeted for Unity 3.5.0 or better.

This product expects that you have turned on "Force Text" as your asset serialization mode.

Initially this package was tested with WinMerge on Windows and Xcode FileMerge on Mac.



What is in this package?
------------------------

This package includes a control panel accessed via the menu that prepares scene files for easy comparison.

First access the control panel by clicking the menu item (Window->Open Scene Merge). This will open

the Scene Merge Panel.

This package included a demo scene for comparison testing. This package should work with any scene.

Make sure to always backup your existing project and scene before using this tool.


Panel Options
-------------

Toggle post processor - If you want to turn on/off the post processors, use this checkbox.

Scene Take Snapshot - This will take your active scene from when you last saved it and prepare it for easy comparison.

Scene Compare with Snapshot - This will take your active scene from when you last saved it and compare with the snapshot.

	This will open the comparison in a diff tool if found.

Scene Compare with Previous Version (SVN) - This allows you to compare your working changes.

Sort and Save Scene - This will take your active scene from when you last saved it, prepare and overwrite the scene for

	easy comparison. This will overwrite and prompt to reload your active scene.

Prefab Take Snapshot - This will take a sorted snapshot from the selected prefab.

Prefab Compare with Snapshot - This allows you to compare the selected prefab with the previous snapshot. This is useful

	if you want to compare different prefabs or compare changes you have made to the same prefab.

Prefab Compare with Previous Version (SVN) - This allows you to compare your working changes.

Sort and Save Prefab - This will take the selected prefab from when you last saved it, prepare and overwrite the prefab

	for easy comparison. This will overwrite and reload the prefab affecting the scene.

File Menu - These same buttons are available in the file menu.


3rd party libraries
-------------------

None


Change Log
----------

1.1 - First version. Diff tools are hardcoded and will be configurable in the future.

1.2 - Added prefab sorting

1.3 - Added support for comparing with SVN changes

1.4 - Added post processors for automatic scene and prefab sorting

1.5 - Moved documentation online, added quick object comparison


**Author**

Tim Graupmann 

You can send comments/questions to tim@tagenigma.com and any feedback you send will turn into new features.
