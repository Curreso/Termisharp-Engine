# Termisharp Engine
Easy to use, console based game engine made in C# by a newbie.

## Documentation
This documentation covers all classes inside of the Termisharp game engine.

##
### Values
There are different types of values in Termisharp, that are also present in C#.

` TextColor `
TextColor is a value and property of the ` Text ` class. Using Text.SetColor(ConsoleColor color), allows you to choose from 14 different text colors. TextColor uses ConsoleColor values.
* Black
* Blue
* Cyan
* DarkBlue
* DarkCyan
* DarkGray
* DarkGreen
* DarkMagenta
* DarkRed
* DarkYellow
* Gray
* Green
* Magenta
* Red
* White
* Yellow

<br>
<a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-6.0">Source</a>

##
`Base `
<br>
The base is the core class that all classes inherit from. 

### Methods
` Destroy() `

##
` Text `
<br>
The text class is a class that lets you add text to the console.

### Methods
` Display() `
<br>
` SmoothWrite(int delay) `
<br>
` SetColor(ConsoleColor color) `
<br>
` Destroy() `

##
` Input `
<br>
The input class is a class that lets you allow the user to input text.

### Methods
` Display() `
<br>
` GetInput() `
<br>
` Destroy() `

##
` Prompt `
<br>
The prompt class is a class that lets you display text aswell as allowing the user to input stuff.

### Methods
` Display() `
<br>
` SmoothWrite(int delay) `
<br>
` Destroy() `

##
` Player `
<br>
The player class is a powerful class that lets you create a player.

### Methods
` Move(int x, int y) `
<br>
` Teleport(int x, int y) `
<br>
` GetPosition() `
<br>
` CreateCharacterCreationSession() `
<br>
` Destroy() `

##
` BeepSequence `
<br>
The BeepSequence class lets you beep the console once, or up to 12 times.

### Methods
` Beep() `
<br>
` CreateSequence(int length) `
<br>
` Destroy() `

##
` App `
<br>
The app class is a powerful class that lets you modify the console.

### Methods
` SetBackgroundColor(ConsoleColor color) `
<br>
` SetForegroundColor(ConsoleColor color) `
<br>
` Clear() `
<br>
` Destroy() `

##
` Subject `
<br>
The subject class is a powerful class that lets you create entities that can act as enemies, countries, troops, NPCs, etc in your games.

### Methods
` Move(int x, int y) `
<br>
` Teleport(int x, int y) `
<br>
` GetPosition() `
<br>
` ToggleVanished() `
<br>
` Destroy() `

##
` Error `
<br>
The error class is a powerful class that lets you create errors. Mostly used in core Termisharp classes, and is not recommended in normal scripts.

### Methods
` SetErrorContent(string err) `
<br>
` Write() `
<br>
` Destroy() `

##
` Group `
<br>
The group class is a powerful class that lets you create groups, which act like C# lists.

### Methods
` AddItem(string item) `
<br>
` Destroy() `
