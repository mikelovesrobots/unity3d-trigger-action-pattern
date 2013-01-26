**Trigger/Action** is an organizational strategy that loosely couples an event like
pressing a key or an object entering a trigger to an action like spawning a monster.
This makes your code more flexible and friendlier to make changes to.

The Rant
========

Typically people code Unity behaviours like this (if you're lucky):

```
using UnityEngine;
using System.Collections;

[RequireComponent (typeof(MonsterSpawner))]
public class MonsterTrap : MonoBehaviour {
  private MonsterSpawner monsterSpawner;

  private void Start() {
    monsterSpawner = GetComponent<MonsterSpawner>();
  }
 
  private void OnTriggerEnter(Collider other) { 
    monsterSpawner.Spawn();
  }
}
```

The problem with this class, simple as it is, is that the effect, spawning a 
monster, is coupled too tightly to the cause, something entering the trigger.  
If you decide in the future that you actually need another trigger by a nearby 
door, you'll have to split this class into two classes.  This kind of rewriting 
feels sucky because it is sucky.  The original class was simply doing too much.

My solution is to always break the causes (triggers) into separate classes from
the effects (actions).  Keep the triggers and actions only doing one small thing
and always implement the same interface.  This allows developers to wire these
small pieces together in the editor into reusable prefabs.  

As an example, if we were to build this MonsterTrap into a prefab using 
Trigger/Action, it would probably look like this:

```
MonsterTrap (GameObject)
  - BoxCollider
  - EnterColliderTrigger
  - SpawnGameObjectAction
```

Now let's modify it to put another trigger by the window:

```
MonsterTrap (GameObject)
  - Door Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Window Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Spawner (GameObject)
    - SpawnGameObjectAction
```

But this can spawn multiple times, so let's put the OnceAction in front of the spawn action.

```
MonsterTrap (GameObject)
  - Door Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Window Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Spawner (GameObject)
    - OnceAction
      - SpawnGameObjectAction
```

Now let's add a scary sound when it spawns:

```
MonsterTrap (GameObject)
  - Door Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Window Trigger (GameObject)
    - BoxCollider
    - EnterColliderTrigger
  - Spawner (GameObject)
    - OnceAction
      - SeriesAction
        - PlaySoundAction
        - SpawnGameObjectAction
```

The point here, and there is a point, is that when triggers are loosely coupled 
to actions and all actions have the same interface, actions become composable. 
You write an action once and re-use it in a bunch of places.  This feels right
because it's working at the right level of abstraction.  And as a bonus, you've
now got a reusable prefab.


To Install
==========

Drop the TriggerAction folder inside Assets/Plugins (Create Plugins if it 
doesn't exist.)


Included Triggers
================

KeypressTrigger
---------------
When a button is pressed, fires off the attached action.

EnterColliderTrigger
--------------------
When an object enters the trigger, fires off the associated action.  Remember 
that you can create custom layers in Unity3d that only react when a particular 
gameObject (like the player) enters.

StartTrigger
------------
Fires the action immediately when the gameObject fires its Start() callback.


Included Actions
==============

CooldownAction
--------------
Utility action that will call another action, but will not fire again until an 
amount of time has passed.  Super useful for controlling player attacks.

DebugAction
-----------
Simply prints to the log.  Useful for figuring out if a complex chain is 
working correctly.

DelayedAction
-------------
Utility action that when called will wait a specified time, then fire another 
action.  Useful for timing things like destroying a crossbow bolt 10 seconds
after it's been spawned.

LockCursorAction
----------------
Utility action that hides the cursor.

OnceAction
----------
Utility action that will call another action, but just once, then it silently
ignores all action calls.

PlaySoundAction
---------------
Plays the attached AudioSource.

QueueAnimationAction
--------------------
Crossfade queues up the specified animation.

RandomChanceAction
------------------
Utility action that will fire the attached action a given percentage of the 
time.  This is useful for introducing a little randomness into your game.

RandomPositionAction
--------------------
Repositions the named GameObject somewhere randomly between the specified
MinPosition and MaxPosition.

RemoveGameObjectsActions
------------------------
Deletes the named gameobjects.

SeriesAction
------------
Utility action that runs the specified other actions in turn.

SetActiveAction
---------------
Sets a target GameObject to active or disabled depending on the setToActive
setting.

ShiftSplitterAction
-------------------
When the action is fired and the user is holding down shift, fires one action,
otherwise fires another action.

SpawnGameObjectAction
---------------------
Spawns a specified gameObject.  Options include:

* `attachToSelf` -- specifies if this gameObject should be parent or not
* `isTemporary` -- indicates the spawned object should be deleted
* `lifespan` -- indicates how long the object should live

These last two settings are useful for one-shot particle emitters.

ToggleAction
------------
Utility action that alternates between firing one action or another.  Useful for
enabling and disabling menus.

UnlockCursorAction
------------------
Shows the cursor.  Useful for enabling the cursor for menus after disabling it 
in game.


How do I write my own custom actions and triggers?
==================================================

First, check out the source to the provided triggers and actions.  They're not
complicated at all.

TriggerBase
-----------

Build most of your custom trigger classes by inheriting from TriggerBase.  Call 
Trigger() when you want to fire off the associated action.

ActionBase
----------
Build most of your custom actions by inheriting from ActionBase.  Simply 
override the Action() method in your new class with your payload code and you're 
good to go.


Note from the Author
=======================

I hope you find this a useful way to organize your code.  I used these triggers 
and actions in my game, Piggyback dungeon Ryder, and felt that the benefits of 
organizing my code this way far outweighed the drawbacks -- which to be fair
are mainly the overhead of managing prefabs.

Feel free to contact me if you have any questions, comments, potential contract 
work, or want to contribute anything back.  I love pull requests.  

Cheers,

Mike Judge

mikelovesrobots@gmail.com

@mikelovesrobots on Twitter
