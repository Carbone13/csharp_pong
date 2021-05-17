using System;

namespace csharp_pong
{
    public static class Program
    {
        [STAThread]
        static void Main ()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}