**trigger-Action-surge** is an extension for the trigger-action library that
adds tweening via the Surge library.

To Install
==========
Drop the trigger-action-surge folder into your project root. Also install Surge
from the asset store.

Included Triggers
=================

MoveByAction
------------
Tweens the position of the transform by the given increment. Good for things 
like moving a character forward one unit.

MoveFromAction
--------------
Tweens the transform from the given position to the current position.

MoveToAction
------------
Tweens the transform to the given position. Good for any sort of move really.

ScaleByAction
-------------
Tweens the local scale of the transform by the given increment. Good for things
like doubling in size every time a pickup happens.

ScaleFromAction
---------------
Tweens the local scale of the transform from the given scale to the current
scale. Good for appearances of newly spawned enemies. Ha ha! I'm here!

ScaleToAction
-------------
Tweens the local scale of the transform to the given scale. Good for disappearances
and any other sort of rescaling where you don't want to worry about taking the 
current scale into account.

