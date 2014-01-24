Network Distributed Baking
--------------------------

**Quick Links**

<a target=_blank href="https://www.assetstore.unity3d.com/#/content/4305">[Network Distributed Baking]</a> is available in the Unity Asset Store.

<a target=_blank href="http://forum.unity3d.com/threads/149836-Network-Distributed-Baking?p=1026463">[Unity Showcase Thread]</a>

Audience
--------

Anyone looking to speed up their content creation work flow and divert their processing time to other machines.


Compatibility
-------------

This project is targeted for Unity 3.5.5 or better.

The networking component is completely standalone and will not require additional setup.

Light baking quality is going to depend on your Unity version. The Unity (free) quality will be less than the full

Unity (PRO) quality of Beast.


What is in this package?
------------------------

This package includes a control panel accessed via the menu that manipulates "Masters" and "Slaves" to perform baking

on other machines. "Masters" create jobs for the "Slaves" to complete over the network.

First access the control panel by clicking the menu item (Window->Open Network Distributed Baking). This will open

the Distributed Panel. From here you can access the configuration and enter the sub/domain/machine name to your server. Servers

can run within your network, or across the Internet if you add an A-Record and use port-forwarding to access your sub/domain.

With your server configured, connect as "Master" or "Slave". "Slaves" will announce availability on the "Masters" channel.


Master Options
--------------

Remote Bake Scene - With an active scene option, this will instruct the "Slave" to bake the active scene open on the "Master".

Remove Bake Selected - With a static game object selected in the scene, this will instruct the "Slave" to bake the selected object.

Send Selected Objects (count) - (In progress) this will send a file from the master to the slave.


Server Setup
------------

You will find detailed tutorial videos on our YouTube channel: http://www.youtube.com/playlist?list=PL265FA9A725E122DF playlist.


Notes on networking
----------------

1) Browsing the master should return a "Hello World" message.

2) You can test the master by hitting the machine and port in a browser. http://YourMachineName:Port

3) You can test the master by hitting a domain and port in a browser. http://YourDomain:Port

4) You can test the master by hitting a sub-domain and port in a browser. http://YourSubDomain.YourDomain:Port

5) Check your firewall to make sure incoming connections on the specified port (defaults to 80) are not blocked.

6) (Optional) On your router use port-forwarding to route external traffic to your master server.

7) (Optional) Find your external IP address easily by doing a web search for "what's my IP address".

8) (Optional) If you own a domain, you can create an A-Record which will use your external IP address.
	demo.mydomain.com <-- external IP address
	
9) If you've used an A-Record, the Distributed Panel should connect over the Internet.


3rd party libraries
-------------------

LitJSON - Enables JSON conversions and is under public domain - http://litjson.sourceforge.net/

SharpZipLib - (Also part of the Unity install), provides compression under GPL - http://www.icsharpcode.net/OpenSource/SharpZipLib/


Change Log
----------

0.1 - Alpha version. Added networking client. Created basic commands for baking the selected scene and baking the selected object.

0.2 - Bug fixes.

0.3 - Replaced networking implementation to work completely via standalone.

0.4 - Added compression when sending objects and stability.

0.5 - Alpha version. Speed up ping times. Auto save scene and project when sending files and requesting bake operations.

0.6 - Added path empty string checking. Added version number to panel. Refactoring. Ensure lightmap textures import with lightmap texture type.

Q & A
-----

You can send comments/questions to support@theylovegames.com where your feedback will help us create new tutorials and features in order to improve the product.
