## Destiny Out-of-Bounds Helper Tool

![DOHT](https://i.imgur.com/44HMECY.png)

This is a PS3 RTM/Mod tool designed to help you explore out of box in Destiny 1

### Prerequisites

1. I will **NOT be providing a release build on Github** for this tool, due to the nature of what it does.
   I will provide a tutorial below for building, however, and I will put the compiled build in my Discord server (you can find that in the tool)

2. You must have VS22+ with C# and .NET 4.5+
3. You must have a **JAILBROKEN/SOFT MODDED Playstation 3 Console**.
   My console is DEX on 4.84 Rebug however this will probably work for HEN users because of PS3MAPI.
4. You must be on the US region version of Destiny (BLUS31181)
5. You must be on update/patch v1.24 (the latest version)

### How to Build

1. Download source
2. Open solution in Visual Studio
3. If you're getting InitializeComponent errors, you're using an older version of C#, most commonly 7.3.
   Please upgrade to C# 8.0
4. Click Build > Build Solution, or you can run the program directly from VS using the green "Start" button

### How to Use

1. After a successful build, open the program up.
2. Open Destiny on your Modified PS3 **(You must be online and on the 1.24 Taken King patch)**
3. On the tool, click Connect to Console, and follow through the pop-up boxes
   (Some people get stuck on the attach part, just click the refresh button
   until text pops up in the box and click connect)
5. If the tool connected successfully, you'll see the status text change. If not, connection was unsuccessful.
   Most commonly your IP was wrong or the connection method you selected (CCAPI, TMAPI, PS3MAPI) was incorrect.
   Also remember TMAPI users must be using a debug eboot.
6. Do **NOT** enable any cheats until you are in-game and can actually move your character.
7. Once in a patrol instance or mission, you can enable functions

### How to OOB

1. Find an area you want to explore out of the box.
2. Use No Collision, No Gravity and Break Turn Back Barriers to walk outside of the map.
   (No Gravity will prevent your character from getting a massive burst of upward momentum due to how Break Turn Back Barriers works, however, this is very useful for
   getting high above a map)
3. You can use No Floors and God Mode to get below a map and avoid the death barrier below. God Mode will not stop your character from hitting the true edge unfortunately.
4. Use No Gravity to traverse outside the box
5. You can also ride sparrows whilst having No Gravity enabled, allowing you to sparrow fly around in areas that allow you to ride your sparrow. Useful for getting around since
   it's faster than just boosting around.
