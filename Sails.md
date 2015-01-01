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

## Setup `Cloud 9` Account

* Register a free account on [Cloud 9](https://c9.io).

* On the `Cloud 9` dashboard, click `CREATE NEW WORKSPACE` and select `Create a New Workspace`.

![Create Workspace](Sails/image-4.png)

* Name your `workspace`. Select `Hosted` hosting with a `Node.js` service. Click the `CREATE` button. The create process runs for about 5 minutes... 

![Create Node.js](Sails/image-5.png)

## How to Setup `Sails.js` on `Cloud 9`.

* In the `dashboard` click on the newly created `workspace` and click `START EDITING`.

![Edit Workspace](Sails/image-6.png)

* Open a new `Terminal Window`.

![Terminal Window](Sails/image-1.png)

* Install `Sails.js` via the `Terminal Window`. The `NPM` package manager will install sails globally with the `-g` option.

`
sudo npm -g install sails
`

![Install Sails](Sails/image-2.png)

* Create a new `Sails.js` project.

```
sails new sailsDemoProject
```

![Create Project](Sails/image-7.png)

* Change to the project folder and start the `Sails.js` server.

```
cd sailsDemoProject/
sails lift
```

![Run Project](Sails/image-8.png)

* Find `server.js` within your project, right-click and choose `Run`.

![Preview Project](Sails/image-9.png)

* Running `server.js` will display the link to browse the project.

![Preview Browser](Sails/image-11.png)

* Entering the link in the preview browser will display the project.

![Display Project](Sails/image-10.png)

## Create Leaderboards Demo

Any game that has scoring will likely have a leaderboards feature. Here's how you can make a leaderboard in `Sails.js`.

* In the terminal, create a demo project. Switch to the project directory and restart `Sails.js`.

```
sails new leaderboardDemo
cd leaderboardDemo
sails lift
```

![Create demo](Sails/image-12.png)

* Preview the page to confirm `Sails.js` has loaded.

![Preview leaderboard](Sails/image-14.png)

* In the terminal create a `leaderboard` api model and restart `Sails.js`.

```
sails generate api leaderboard
sails lift
```

![Generate Leaderboard](Sails/image-13.png)

* The `Leaderboard.js` API model will be generated.

![Generate Leaderboard](Sails/image-16.png)

* Preview the leaderboard API page to verify the API has been created. The result set will be empty at first.

![Leaderboard API](Sails/image-15.png)