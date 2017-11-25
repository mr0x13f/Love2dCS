
![logo](https://github.com/endlesstravel/Love2dCS/raw/master/img/logo.png "logo") 

Love2dCS - C# Wrapper for LÖVE
---
Love2dCS is a C# Wrapper for [LÖVE game engine](https://love2d.org/), it can be used your C# based Application. 

Love2dCS was designed to be as close as possible to the original LÖVE API, as such the documentation provided from LÖVE largely covers usage of Love2dCS. Niceties different Love2dCS

Love2dCS currently supports Windows x86. The next step will be to support windows x64. Linux and OSX temporarily was not supported.

Feature
---

* Easy to install
* Easy to use

*In development ...*

Setup
---

1. Available on NuGet: https://www.nuget.org/packages/Love2dCS/

2. And **REMEBER** enable native code debugging in VS : `Configuration Properties/Debugging/Enable native code debugging`

More detail please reference [Setup-Detail](README-Install.md)

Usage
---

1. Emptye projcet - No game Sence will automatically run
``` C#
class Program
{
    static void Main(string[] args)
    {
        Love2d.Boot.Run();
    }
}
```

2. Drawing text
``` C#
using Love2d.Module;
namespace Example
{
    class Program : Love2d.Scene
    {
        public override void Draw()
        {
            Graphics.print("Hello World!", 400, 300);
        }

        static void Main(string[] args)
        {
            Love2d.Boot.Run(new Program());
        }
    }
}
```

3. Drawing an image
``` C#
using Love2d.Type;
using Love2d.Module;
namespace Example
{
    class Program : Love2d.Scene
    {
        Image img = null;

        public override void Load()
        {
            img = Graphics.newImage("logo.png");
        }

        public override void Draw()
        {
            Graphics.draw(img, 300, 200);
        }

        static void Main(string[] args)
        {
            Love2d.Boot.Run(new Program());
        }
    }
}
```

4. Playing a sound
``` C#
using Love2d.Type;
using Love2d.Module;
namespace Example
{
    class Program : Love2d.Scene
    {
        Source source = null;

        public override void Load()
        {
            source = Audio.newSource("music.mp3");
            source.play();
        }

        static void Main(string[] args)
        {
            Love2d.Boot.Run(new Program());
        }
    }
}
```

5. Key event handle - Press `Escape` to exit
``` C#
using Love2d.Module;
namespace Example
{
    class Program : Love2d.Scene
    {
        class ExitEventHandler : Love2d.EventHandler
        {
            public override void KeyPressed(Keyboard.Key key, Keyboard.Scancode scancode, bool isRepeat)
            {
                if (Keyboard.Key.KEY_ESCAPE == key)
                    Event.quit();
            }
        }

        static void Main(string[] args)
        {
            Love2d.Boot.Run(new Program(), new ExitEventHandler());
        }
    }
}
```

Doucment
---
*In development ...*

Temporarily reference [love wiki](https://love2d.org/wiki/love)

Develpoment
---

*In development ...*