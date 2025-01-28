using RLNET;

namespace RogueSharpV3Tutorial
{
    public class Game
    {
        // The screen height and width are in number of tiles
        private static readonly int screenWidth = 100;
        private static readonly int screenHeight = 70;

        private static RLRootConsole rootConsole;

        public static void Main()
        {
            // This must be the exact name of the bitmap font file we are using or it will error.
            string fontFileName = "terminal8x8.png";
            // The title will appear at the top of the console window
            string consoleTitle = "RougeSharp Tutorial - level 1";
            // Tell RLNet to use the bitmap font that we specified and that each tile is 8 x 8 pixels
            rootConsole = new RLRootConsole(fontFileName, screenWidth, screenHeight,
                8, 8, 1f, consoleTitle);
            // Set up a handler for RLNET's Update event
            rootConsole.Update += OnRootConsoleUpdate;
            // Set up a handler for RLNET's Render event
            rootConsole.Render += OnRootConsoleRender;
            // Begin RLNET's game loop
            rootConsole.Run();
            
            // Event handler for RLNET's Update event
            static void OnRootConsoleUpdate(object sender, UpdateEventArgs e)
            {
                rootConsole.Print(10, 10, "It Worked!", RLColor.White);
            }
            
            // Event handler for RLNET's Render event
            static void OnRootConsoleRender(object sender, UpdateEventArgs e)
            {
                // Tell RLNET to draw the console that we set
                rootConsole.Draw();
            }
        }
    }
}