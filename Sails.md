# Sails.js

[Sails.js](http://sailsjs.org) is a powerful web framework that auto-generates REST APIs and the socket layer simultaneously.

Follow the [Getting Started](https://github.com/balderdashy/sails-docs/blob/master/getting-started/getting-started.md) docs to get started with Sails.

<table border=1>
 <tr>
 <td>Intro to Sails.js (00:14:44)<br/>
<a href="http://www.youtube.com/watch?feature=player_embedded&v=GK-tFvpIR7c" target="_blank">
<img src="http://img.youtube.com/vi/GK-tFvpIR7c/0.jpg" alt="Intro to Sails.js" width="240" height="180" border="10" /></a></td>
 </tr>
</table>

## How to Setup `Sails.js` on `Cloud 9`.

* Register a free account on [Cloud 9](https://c9.io).

* On the `Cloud 9` dashboard, click `CREATE NEW WORKSPACE` and select `Create a New Workspace`.

![New Terminal](Sails/image-4.png)

* Name your `workspace`. Select `Hosted` hosting with a `Node.js` service. Click the `CREATE` button. The create process runs for about 5 minutes... 

![New Terminal](Sails/image-5.png)

* In the `dashboard` click on the newly created `workspace` and click `START EDITING`.

![New Terminal](Sails/image-6.png)

* Open a new `Terminal Window`.

![New Terminal](Sails/image-1.png)

* Install `Sails.js` via the `Terminal Window`. The `NPM` package manager will install sails globally with the `-g` option.

`
sudo npm -g install sails
`

![Install Sails](Sails/image-2.png)

* Create a new `Sails.js` project.

```
sails new sailsDemoProject
```

![Install Sails](Sails/image-7.png)

* Change to the project folder and start the `Sails.js` server.

```
cd sailsDemoProject/
sails lift
```

![Install Sails](Sails/image-8.png)

* Find `server.js` within your project, right-click and choose `Run`.

![Install Sails](Sails/image-9.png)

* Running `server.js` will display the link to browse the project.

![Install Sails](Sails/image-11.png)

* Entering the link in the preview browser will display the project.

![Install Sails](Sails/image-10.png)