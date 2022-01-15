# Termisharp Engine
Easy to use, console based game engine made in C# by a newbie.

## Documentation
This documentation covers all classes inside of the Termisharp game engine.

##
### Values
There are different types of values in Termisharp, that are also present in C#.

` TextColor `
TextColor is a value and property of the ` Text ` class. Using Text.SetColor(string color), allows you to choose from 14 different text colors. TextColor uses ConsoleColor values.
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
The base is the core class that all classes inherit from. 

### Methods
` Destroy() `

##
` Text `
The text class is a class that lets you add text to the console.

### Methods
` Display() `
<br>
` SetColor(ConsoleColor color) `
<br>
` Destroy() `

##
` Input `
The input class is a class that lets you allow the user to input text.

### Methods
` Display() `
<br>
` GetInput() `
<br>
` Destroy() `

##
` Prompt `
The prompt class is a class that lets you display text aswell as allowing the user to input stuff.

### Methods
` Display() `
<br>
` Destroy() `

##
` Player `
The player class is a class that lets you create a player.

### Methods
` Move(int x, int y) `
<br>
` Teleport(int x, int y) `
<br>
` CreateCharacterCreationSession() `
<br>
` Destroy() `

##
` BeepSequence `
The BeepSequence class lets you beep the console once, or up to 12 times.

### Methods
` Beep() `
<br>
` CreateSequence(int length) `
<br>
` Destroy() `

##
` App `
The app class is a class that lets you modify the console.

### Methods
` SetBackgroundColor(ConsoleColor color) `
<br>
` SetForegroundColor(ConsoleColor color) `
<br>
` Destroy() `
