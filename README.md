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

<a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-6.0">Source</a>

##
`Base `

The base is the core class that all classes inherit from. 

### Methods
` Destroy() ` ` Void ` 

Destroys the class.

##
` Text `

The text class is a class that lets you add text to the console.

### Methods
` Display() ` ` Void `

Displays the TextContent property.

` SmoothWrite(int delay) ` ` Void `

Smoothly writes the TextContent property. Delay parameter are the milliseconds between each character.

` SetColor(ConsoleColor color) ` ` Void `

Sets the color of the text.

` Destroy() ` ` Void `

Destroys the class.

##
` Input `

The input class is a class that lets you allow the user to input text.

### Methods
` Display() ` ` Void `

Displays the input.

` GetInput() ` ` String `

Returns the Value property.

` Destroy() ` ` Void `

Destroys the class.

##
` Prompt `
<br>
The prompt class is a class that lets you display text aswell as allowing the user to input stuff.

### Methods
` Display() `

Displays the prompt.

` SmoothWrite(int delay) `

Smoothly writes the Title property. Delay parameter are the milliseconds between each character.

` Destroy() `

Destroys the class.

##
` Player `

The player class is a powerful class that lets you create a player.

### Methods
` Move(int x, int y) `

Allows you to change

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
