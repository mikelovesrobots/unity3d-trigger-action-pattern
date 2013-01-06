**Trigger/Action** is an organizational strategy that loosely couples an event like
pressing a key to an action like spawning a monster.

Synopsis
========

When you loosely couple triggers to actions (and all the actions have the same
interface), it makes it really easy to swap actions or have multiple triggers 
fire off the same action.  This can be really powerful and save you a lot of 
time. 
 
For example, let's say you build a QuicksaveAction that saves your game.  It 
could be fired off by a KeypressTrigger bound to f5, a ConsoleCommandTrigger
bound to "quicksave", and an in-game ElevatorButtonTrigger bound to a 
SeriesAction which fires off CutsceneAction, LevelLoadAction, and
QuicksaveAction.  Same payload, called from three different places, connected 
together only in the Unity3d editor.


Script Rundown
==============

KeypressTrigger
------------
KeypressTrigger is a component that when a button is pressed, fires off the 
Action method on the Action component attached to the same GameObject.

This of course implies that you create a separate GameObject for each Input 
button in your game.  Yes.  Good.  Single Responsibility Principle is a nice
way to organize your code.

ActionBase
----------
Build most of your custom actions by inheriting from this guy.  Simply override 
the Action() method in your new class with your payload code and you're good to 
go.  There's some examples down below of custom actions.

ToggleAction
------------
Need an action that toggles on and off?  Build a custom action that inherits 
from this guy instead.  Override OnToggleEnable() and OnToggleDisable() and 
you're done.

GameObjectToggleAction
----------------------
Need a GameObject to be enabled or disabled?  Just drag this in place, set the 
target GameObject and attach a trigger.  No coding required.

SeriesAction
------------
Want to fire off many actions in a row?  Drag this in place, and attach the 
GameObjects containing the actions you want to trigger.


Custom Action Examples
======================

Note: neither of these will actually run as they're missing some externally
referenced classes.  They're still good examples.

QuickloadAction Example
-----------------------

Scene Hierarchy:
  Global > Input > Quickload:
    InputTrigger (w/button set to f9)
    QuickloadAction

Code:
    // QuickloadAction.cs
    using UnityEngine;
    using System.Collections;

    public class QuickLoadAction : ActionBase {
      public override void Action () {
        new LevelLoader(MapEditorSettings.quicksaveFilename).Load();
      }
    }

RemoveAction Example
--------------------

Scene hierarchy:
   Global > Input > Remove:
     InputTrigger (w/button set to 'remove')
     RemoveAction

Code:
    // RemoveAction.cs
    using UnityEngine;
    using System.Collections;

    public class RemoveAction : ActionBase {
      public string removableGameObjectTag = "Removable";

      public override void Action () {
        CrosshairRayCasterResult result = CrosshairRayCaster.Cast();
        if (result.success) {
          GameObject target = result.gameObject;
          if (target.tag == removableGameObjectTag) {
            Destroy(target);
          }
        }
      }
    }

Note from the Author
=======================

I've extracted this pattern from my own code.  I hope you'll find it a useful 
way to organize your code.

Feel free to contact me if you have any questions, comments, potential contract 
work, or want to contribute anything back.  I love pull requests.  

Cheers,

Mike Judge
mikelovesrobots@gmail.com
@mikelovesrobots on Twitter
