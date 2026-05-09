<h3>Out</h3>
Animates a string one character at a time <br>
Parameters;
<ul>
	<li> string message </li>
	<li> int delay between each character (ms) </li>
	<li> bool create a new line at the end? (defaults to yes) </li>
</ul>

```c#
// Example
Out("this is a message", 50, true);
```

```
// Output
this is a message
```

<h3>YesNo</h3>
Returns true or false after getting the user to select yes or no<br>
It also allows for variations, e.g. y / n<br>
Parameters;
<ul>
	<li> string question </li>
</ul>

```c#
// Example
if ( YesNo("this is a question") )
{
	Console.WriteLine("You selected yes");
}
else
{
	Console.WriteLine("You selected no");
}

// Alternative
bool answer = YesNo("this is a question");

if (answer)
{
	Console.WriteLine("You selected yes");
}
else
{
	Console.WriteLine("You selected no");
}
```

<h3> GetOption </h3>
Allows you to pass a list of options, and the user must type a <b>valid</b> option<br>
Once a valid option has been typed, it is returned as a string.<br>
Parameters;
<ul>
	<li>List<string> options list</li>
</ul>

```c#
// Example
List<string> options = new List<string>{ "option1", "option2" };

string answer = GetOption(options);

if (answer == "option1")
{
	Console.WriteLine("You selected option 1!");
}
else
{
	Console.WriteLine("You selected option 2!");
}
```

<h3> ListOptions </h3>
Allows user to output each item within a list of any standard datatype
Parameters;
<ul>
	<li>List<string> options list</li>
</ul>

```c#
// Example
List<string> options = new List<string> {"option 1", "option 2"}

string output = ListOptions(options);

// Output
> option 1
> option 2
```