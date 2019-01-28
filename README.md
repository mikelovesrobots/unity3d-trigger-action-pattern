**Trigger/Action** is an organizational strategy that loosely couples events to 
actions. It's what happens if you take single responsibility principle to its
logical conclusion. Not only is code easier to work on, but it's faster to
prototype in and easier to wire up.

To Install
==========

Drop the TriggerAction folder inside Assets/Plugins (Create Plugins if it 
doesn't exist.)

Included Triggers
================

KeypressTrigger
---------------
When a button is pressed, fires off the attached action.

EnterTriggerTrigger
--------------------
When an object enters the trigger, fires off the associated action.  Remember 
that you can create custom layers in Unity3d that only react when a particular 
gameObject (like the player) enters.

StartTrigger
------------
Fires the action immediately when the gameObject fires its Start() callback.

UpdateTrigger
------------
Fires the action immediately when the gameObject fires its Start() callback.


Included Actions
==============

CooldownAction
--------------
Utility action that will call another action, but not fire again (no matter
how many times it is called) until an amount of time has passed.
Super useful for controlling player attacks.

DebugAction
-----------
Simply prints to the log. Useful for figuring out if a complex chain is 
working correctly.

DelayedAction
-------------
Utility action that when called will wait a specified time, then fire another 
action.  Useful for timing things like destroying a crossbow bolt 10 seconds
after it's been spawned.

HitPauseAction
--------------
Freezes the game for a few frames when this action is hit. Useful for giving a
feeling of weight to player hits.

LockCursorAction
----------------
Utility action that hides the cursor.

OnceAction
----------
Utility action that will call another action, but just once, then silently
ignore all future action calls.

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

RandomSampleAction
------------------
Utility action that when called will randomly choose one of the attached actions,
and fire it.  This is useful for introducing a little randomness into your game.

RemoveGameObjectActions
------------------------
Deletes a gameobject.

RemoveGameObjectsActions
------------------------
Deletes a number of gameobjects.

SendUnityEventAction
--------------------
Utility action that can be used to call nearly anything. Easy to overuse.

SeriesAction
------------
Utility action that runs the specified other actions in turn.

SetActiveAction
---------------
Sets a target GameObject to active or disabled depending on the setting.

ShiftSplitterAction
-------------------
When the action is fired and the user is holding down shift, fires one action,
otherwise fires another action. Perhaps a little overly specialized for this
collection.

SpawnPrefabAction
---------------------
Spawns a specified gameObject.  Options include:

* `AttachToSelf` -- boolean that specifies if this gameObject should be the parent
* `IsTemporary` -- indicates the spawned object should eventually be deleted
* `TemporaryLifespan` -- indicates how long the object should live

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

Trigger
-------
A trigger is any class that takes an ActionBase and calls ActionBase.Act() on it.

ActionBase
----------
Inherit from ActionBase and override the Act() method in your class with your
payload code.


Note from the Author
=======================

I hope you find this a useful way to organize your code.  I used these triggers 
and actions in a number of my games including Exploding Kittens for iOS and 
Android.

Feel free to contact me if you have any questions, comments, potential contract 
work, or want to contribute anything back.  I love pull requests.  

Cheers,

Mike Judge

mikelovesrobots@gmail.com

@mikelovesrobots on Twitter
