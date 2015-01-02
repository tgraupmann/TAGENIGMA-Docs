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

* Add records to the leaderboard data by hitting the API create page. More details are available on the page [Create a record](http://sailsjs.org/#/documentation/reference/blueprint-api/Create.html) in the `Blueprint API`.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard/create?name=timg&score=10
```

![Leaderboard API](Sails/image-17.png)

* The leaderboard page will show data has been added.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard
```

![Leaderboard API](Sails/image-18.png)

* Limit list to `10` records and sort by a descending `Score`.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard?limit=10&sort=score%20DESC
```

![Leaderboard API](Sails/image-19.png)

* If two people have the same score, sort by id.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard?limit=10&sort=score%20DESC%20id%20ASC
```

![Leaderboard API](Sails/image-20.png)

* If two people have the same score, sort by `createdAt`.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard?limit=10&sort=score%20DESC%20createdAt%20ASC
```

![Leaderboard API](Sails/image-21.png)

* To sort `Score` values properly change the `leaderboard model` attribute field for `Score` to use an `integer` type. Otherwise the `Score` values would sort in `String` order which is not ideal.

```
module.exports = {
  attributes: {
    name:{type:'string'},
    score:{type:'integer'}
  }
};
```

![Leaderboard API](Sails/image-24.png)

* Destroy will remove a record using the "id" field. More details are available on the page [Destroy a record](http://sailsjs.org/#/documentation/reference/blueprint-api/Destroy.html) in the `Blueprint API`.

```
https://sailsdemo-tgraupmann.c9.io/leaderboard/destroy?id=1
```

![Leaderboard API](Sails/image-22.png)

## Accessing Leaderboard Data from Unity

The [UnitySailsLeaderboard](https://github.com/tgraupmann/tagenigma-examples/tree/master/UnitySailsLeaderboard) example reads the `Sails.js` leaderboard data to display using the new Unity 4.6 UI.

* Be sure to inspect the `LeaderboardManager` and in the inspector set the `Cloud9` fields for your `Username` and `Project Name`. 

![Leaderboard API](Sails/image-23.png)
