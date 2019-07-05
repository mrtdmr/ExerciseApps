using System;

namespace DesignPatterns.Creational.Factory
{
    enum ScreenMode
    {
        Windows,
        Mobile,
        Web
    }
    /// <summary>
    /// Creator Class
    /// </summary>
    class Creator
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="screenMode"></param>
        /// <returns></returns>
        public Screen ScreenFactory(ScreenMode screenMode)
        {
            Screen screen = null;
            switch (screenMode)
            {
                case ScreenMode.Windows:
                    screen = new WinScreen();
                    break;
                case ScreenMode.Mobile:
                    screen = new MobileScreen();
                    break;
                case ScreenMode.Web:
                    screen = new WebScreen();
                    break;
                default:
                    break;
            }
            return screen;
        }
    }
    /// <summary>
    /// Product
    /// </summary>
    public abstract class Screen
    {
        public abstract void Draw();
    }
    /// <summary>
    /// Concreate Product
    /// </summary>
    public class WinScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Windows Ekranı...");
        }
    }
    /// <summary>
    /// Concreate Product
    /// </summary>
    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web Ekranı...");
        }
    }
    /// <summary>
    /// Concreate Product
    /// </summary>
    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobile Ekranı...");
        }
    }

    abstract class Creator2
    {
        public abstract Screen ScreenFactory();
    }
    class WinScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WinScreen();
        }
    }
    class WebScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WebScreen();
        }
    }
    class MobileScreenCreator : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new MobileScreen();
        }
    }
}
