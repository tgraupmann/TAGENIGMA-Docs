# Setup For Fuse CC
---

## Quick Links
---

Publisher: <a target=_blank href="http://tagenigma.com/blog">[TAGENIGMA Blog]</a>


## Feedback
---

Send your questions, feedback, or feature requests to [support@theylovegames.com](mailto:support@theylovegames.com).


## Audience
---

Anyone who wants to use [Adobe Fuse CC](http://www.adobe.com/products/fuse.html) to create characters and wants to use those chracters in [Unity](http://unity3d.com/) can use this package.

Anyone who used an existing character from [Mixamo.com](http://mixamo.com) and added the `Scary Zombie Animation Pack` to their character can use this package.

Anyone who uploaded models to [Mixamo.com](http://mixamo.com) and added the `Scary Zombie Animation Pack` to their character can use this package.


## Compatibility
---

This package is targeted for Unity 5.3.1 or better.

This package extends the Unity editor.

This package is compatible with [Adobe Fuse CC](http://www.adobe.com/products/fuse.html).

This package is compatible with animated models from [Mixamo](http://mixamo.com).

This package is compatible with [RAIN AI for Unity](https://www.assetstore.unity3d.com/en/#!/content/23569). 

This package is compatible with [UFPS : Ultimate FPS](https://www.assetstore.unity3d.com/en/#!/content/2943).


## What is in this package?
---

This package includes editor scripts that provide automatic setup via add menu items.

This package includes animated models that were created in `Adobe Fuse CC`.


## Tutorials
---

You will find detailed tutorial videos on our YouTube channel in the [Setup For Fuse CC Playlist](https://www.youtube.com/playlist?list=PL4mjXeDqRBMSgTOKGb8jpQ0tjgMV53VvN).

<table border=1>
 <tr>
 <td>Adobe Fuse CC to Unity UFPS (00:16:15)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=L9MCGwRTlbY" target="_blank">
<img src="http://img.youtube.com/vi/L9MCGwRTlbY/0.jpg" alt="Adobe Fuse CC to Unity UFPS" width="240" height="180" border="10" /></a></td>
 <td>Mixamo to Unity (00:02:11)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=e5WgVEkMk3g" target="_blank">
<img src="http://img.youtube.com/vi/e5WgVEkMk3g/0.jpg" alt="Mixamo to Unity" width="240" height="180" border="10" /></a></td>
 </tr>
 <tr>
 <td>Import RAIN AI for Unity into Unity (00:00:56)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=r8BoYJPc84E" target="_blank">
<img src="http://img.youtube.com/vi/r8BoYJPc84E/0.jpg" alt="Import RAIN AI for Unity into Unity" width="240" height="180" border="10" /></a></td>
 <td>Set up a Waypoint Route in RAIN AI for Unity (00:08:24)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=30rb5Ihphx4" target="_blank">
<img src="http://img.youtube.com/vi/30rb5Ihphx4/0.jpg" alt="Set up a Waypoint Route in RAIN AI for Unity" width="240" height="180" border="10" /></a></td>
 </tr>
 <tr>
 <td>Mixamo to Rain AI For Unity Waypoint Routes (00:03:49)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=mLWW4GwG3Pw" target="_blank">
<img src="http://img.youtube.com/vi/mLWW4GwG3Pw/0.jpg" alt="Mixamo to Rain AI For Unity Waypoint Routes" width="240" height="180" border="10" /></a></td>
 <td>Quick RAIN Setup for Mixamo with Scary Zombie Pack AI (00:04:39)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=h1cVxDnAUlE" target="_blank">
<img src="http://img.youtube.com/vi/h1cVxDnAUlE/0.jpg" alt="Quick RAIN Setup for Mixamo with Scary Zombie Pack AI" width="240" height="180" border="10" /></a></td>
 </tr>
</table>


## Example Scenes
---

Example scenes are located in `Assets/SetupForFuseCC/Scenes`.

Example Scene `RainUFPSWaypoints` - This example scene shows `RAIN` characters running around a `Navigation Mesh` cycling between waypoints. `RAIN` characters have a `Visual Sensor` and will detect players with a `Visual Aspect`. `RAIN` characters chase the player while in visual range. `RAIN` characters will attack the player when close enough. `RAIN` must be imported and enabled before opening this scene. `UFPS` must be imported and enabled before opening this scene.

Example Scene `NavMeshUFPSWaypoints` - This example scene shows `NavMesh Agents`  running around a terrain with obstacles and cycling between waypoints. `NavMesh Agents` have a `Visual Sensor` and will detect players with a `Visual Aspect`. `NavMesh Agents` chase the player while in visual range. `NavMesh Agents` will attack the player when close enough. `UFPS` must be imported and enabled before opening this scene.


## Enable RAIN AI for Unity
---

This package is compatible with [RAIN AI for Unity](https://www.assetstore.unity3d.com/en/#!/content/23569). 

The `RAIN AI for Unity` package must be imported before support is enabled.

To enable support, add `RAIN_AI` to the [Platform Custom Defines](http://docs.unity3d.com/Manual/PlatformDependentCompilation.html).

After support is enabled, `Fuse` submenu items will appear within the `RAIN` menu.

![image_2](Setup-For-Fuse-CC/image_2.png)


## Enable UFPS : Ultimate FPS
---

This package is compatible with [UFPS : Ultimate FPS](https://www.assetstore.unity3d.com/en/#!/content/2943).

The `UFPS` package must be imported before support is enabled.

To enable support, add `UFPS` to the [Platform Custom Defines](http://docs.unity3d.com/Manual/PlatformDependentCompilation.html).

After support is enabled, `UFPS` submenu items will appear within the `Fuse` menu.

![image_2](Setup-For-Fuse-CC/image_1.png)


## Fuse CC
---

This package supports models created in [Adobe Fuse CC](http://www.adobe.com/products/fuse.html). `Fuse CC` is part of `Adobe Creative Cloud`. Design a character and then click the `Save to Mixamo` button to upload the character to the `Mixamo` website for auto-rigging and animation retargeting.

![image_14](Setup-For-Fuse-CC/image_14.png)


## Mixamo
---

[Mixamo](http://mixamo.com) has a collection of characters that can be animated with animation packs and then downloaded into `Unity`.


### Scary Animation Pack

This package supports `Mixamo` models that have the `Scary Animation Pack` applied. Be sure to check the `In Place` option for the animations in the pack to maximize compatibility.

![image_15](Setup-For-Fuse-CC/image_15.png)


## Unity Built-in NavMesh Agents
---

### Getting Started


#### Create a New Scene

Start with a new scene and save the scene. A scene has to be saved to bake a `NavMesh`.

![image_3](Setup-For-Fuse-CC/image_3.png)


#### Create Waypoint Obstacles

The menu item `Fuse->Setup NavMesh [Waypoint Obstacles]` automatically creates a terrain with obstacles and waypoints. Obstacles show that the `NavMesh Agents` can navigate the `NavMesh` while patrolling a set of `Waypoints`.

![image_4](Setup-For-Fuse-CC/image_4.png)

Terrain provides a floor to walk on. Obstacles are a set of cubes shaped like buildings spaced apart to give room for the `NavMesh Agents` to avoid. The obstacles are colored to make navigating the scene easy while inspecting `NavMesh Agents`. The `NavMeshAgentTargets` are a set of `GameObjects` to be used as patrol `Waypoints`.

![image_5](Setup-For-Fuse-CC/image_5.png)


#### Setup the UFPS Player

The menu item `Fuse->Setup NavMesh [UFPS Player]` is only available when `UFPS` is enabled. The menu item creates a `UFPS` player with a `Visual Aspect` for `NavMesh Agents` to sense. The `UFPS` player has a `first-person` controller and is capable of running around the obstacle course. The `UFPS` has the damage handlers, colliders, and a starting inventory already setup. Since `UFPS` players have their own cameras, the default `Main Camera` is disabled. At this point, the player can run around the scene and shoot.

![image_6](Setup-For-Fuse-CC/image_6.png)


#### Setup the Player

The menu item `Fuse->Setup NavMesh [Player] Visual Aspect` adds a `Visual Aspect` to the player so that `NavMesh Agents` can detect the player. This can be used on `UFPS` players or generically on something like the `Standard Assets` where a `Character Controller` was used. A `Visual Aspect` will work for a `first-person` or `third-person` perspective controller.

![image_7](Setup-For-Fuse-CC/image_7.png)


#### Setup NavMesh Agents With Scary Zombie Pack

The menu item `Fuse->Setup NavMesh [Agent] Scary Zombie Pack` can only be used when the main `Mixamo` character model is selected. The menu item will automatically generate an `Animator Controller` for the `Mixamo` character that is compatible with the `Scary Zombie Pack` from `Mixamo`. The `Animator Controller` will be created in the same folder as the `Mixamo` character. The menu item will apply some material fixes on the `Mixamo` model.

![image_8](Setup-For-Fuse-CC/image_8.png)


If the `Mixamo` character has an existing `Animator Controller` the editor will prompt before replacing it.

![image_9](Setup-For-Fuse-CC/image_9.png)


A `GameObject` named `NavMeshAgents` will be added to the scene, if missing, which holds the templates for `NavMesh Agents` that will be spawned. A `GameObject` named `NavMeshAgentSpawners` will be added to the scene, if missing, which holds the spawner instances for the `NavMesh Agents`. The spawners control the rate at which the agents are spawned. New agents will be spawned at the spawner locations. Templates should be deactivated before hitting play. A template might become unspawnable if it gets destroyed by dying if it was accidentally activated in `PLAY` mode.

![image_10](Setup-For-Fuse-CC/image_10.png)


When the `Animator Controller` was generated, the menu item automatically scanned the Mixamo model animations to automatically create all the state transitions. The menu item also auto generated the `Mechanim` parameters used in the state diagram. The `Animator Controller` is already properly referenced by the `NavMesh Agent`.

![image_13](Setup-For-Fuse-CC/image_13.png)


#### Setup NavMesh Agent Templates

The menu item `Fuse->Setup NavMesh [Enemy] Scary Zombie Pack` should only be run on a `NavMesh Agent` template. The menu item performs a subset of setup tasks from the previous item, excluding generating the `Animator Controller`, excluding the material fixes, and excluding creating the spawn items. The menu item adds a `Visual Sensor` so that a `Zombie` can find the `Player`. The menu item also adds a `Capsule Collider` to the spine of the `NavMesh Agent`. The below image has the template enabled only for documentation purposes. `NavMesh Agent` templates should be deactivated to be used properly. 

![image_11](Setup-For-Fuse-CC/image_11.png)


#### Setup NavMesh Agents for UFPS

The menu item `Fuse->Setup NavMesh [UFPS Enemy] Scary Zombie Pack` should only be run on a `NavMesh Agent` template. The menu item adds a `Damage Handler` so that the `Zombie` can be damaged by the `UFPS Player`. The menu item will only display if `UFPS` is enabled. The below image has the template enabled only for documentation purposes. `NavMesh Agent` templates should be deactivated to be used properly. 

![image_12](Setup-For-Fuse-CC/image_12.png)


#### NavMesh Agent Patrols

At this point, the `NavMesh Agents` will cycle between their respective waypoints.

![image_16](Setup-For-Fuse-CC/image_16.gif)


If the `NavMesh Agents` sense a `Visual Aspect` they will chase and attack their target.

![image_17](Setup-For-Fuse-CC/image_17.gif)


## RAIN AI for Unity
---


#### Create a New Scene

Start with a new scene and save the scene.

![image_3](Setup-For-Fuse-CC/image_3.png)


## Change Log
---

1.0 - Initial submission of package.


## Q & A
---

You can send comments/questions to [support@theylovegames.com](mailto:support@theylovegames.com) where your feedback will help us create new tutorials and features in order to improve the product.
