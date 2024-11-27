
public class UiGame
{

    public static int Menu()
    {

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine(@"


                __________                __                     ___ ___              .__                            
                \______   \_______  ____ |  | __ ____   ____    /   |   \  ___________|__|___________   ____   ______
                |    |  _/\_  __ \/  _ \|  |/ // __ \ /    \  /    ~    \/  _ \_  __ \  \___   /  _ \ /    \ /  ___/
                |    |   \ |  | \(  <_> )    <\  ___/|   |  \ \    Y    (  <_> )  | \/  |/    (  <_> )   |  \\___ \ 
                |______  / |__|   \____/|__|_ \\___  >___|  /  \___|_  / \____/|__|  |__/_____ \____/|___|  /____  >
                        \/                    \/    \/     \/         \/                       \/          \/     \/ 

        
            ");

            Console.WriteLine($"------------------------------------------                      󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼 󰐼                 ----------------------------------------------------\n\n\n");


            try
            {
                return Input.SelectInput("Select Option", new List<string> { "Create Game Session and Start", "Load Game", "Exit" });
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Option is a number!");
                Console.ReadKey();
            }


        } while (true);
    }

    public static Player SessionSelector(List<Player> sessions){

        List<string> sessionsString = new List<string>(); 

        foreach(Player session in sessions){
            sessionsString.Add(@$"
        Name: {session.Name}
        Level: {session.CurrentLevel}
        Points: {session.Points}
        ");
        }

        int option = Input.SelectInput("Select your session", sessionsString);

        return sessions[option - 1];
    }


   public static void StartStory()
    {
        Dialog.WriteDialog("The world is no longer what it once was. A nuclear holocaust wiped out humanity, leaving only ruins and despair in its wake. Sean, a young survivor, lost his parents to mutations caused by the radiation. His mission is simple: survive and find out who caused this disaster.", ConsoleColor.Magenta);
        Dialog.WriteDialog("By his side is Helen, a thief with a mysterious past. Though her loyalty is uncertain, both know that cooperation is the only way to have a chance at surviving in this destroyed world.", ConsoleColor.Magenta);
        Dialog.WriteDialog("Together, they journey through the wasteland, hoping to find answers and a way to move forward. But danger lurks around every corner...", ConsoleColor.Magenta);
    }

    public static void EncounterWithSpider()
    {
        //! The story when they encounter the Spider (giant mutated spiders).

        Dialog.WriteDialog("After several days of traveling through a ruined desert, Sean and Helen come across something strange: a thick web covering the ruins of an old city.");
        Dialog.WriteDialog("From the shadows emerge massive mutated spiders, known as Spiders. Their eyes glow like beacons in the darkness, and their sharp legs click as they move.");
        Dialog.WriteDialog("Sean and Helen fight with everything they have. The Spiders strike fast, trying to trap them in their sticky webs. But with agility and cunning, they manage to escape, though the battle leaves a mark: the world is full of monsters, and survival will only get harder.");
    }

    public static void EncounterWithShadowHunter()
    {
        //! The story when they encounter the Shadow Hunter (mutants that move in the dark).

        Dialog.WriteDialog("Night falls quickly as they move through a city even darker, surrounded by towering buildings blocking out the little remaining light.");
        Dialog.WriteDialog("The air grows thick, and something seems to move in the shadows. Sean senses a strange presence, something ominous. Suddenly, they appear: the Shadow Hunters, mutant creatures that only move in the dark.");
        Dialog.WriteDialog("The fight begins. The Shadow Hunters are fast and nearly invisible, moving silently through the shadows. Sean and Helen, unable to see them fully, use the light from a lantern to reveal the creatures.");
        Dialog.WriteDialog("The battle is intense, but with cleverness and teamwork, they manage to defeat the hunters. However, they know the danger is far from over.");
    }

    public static void EncounterWithAlpha()
    {
        //! The story when they encounter Alpha (a powerful mutant enemy).

        Dialog.WriteDialog("The journey continues, but fear lingers. After days of constant battles, Sean and Helen arrive at a zone completely devastated by a previous fight. The ruins of a forgotten war give way to a new threat.");
        Dialog.WriteDialog("From the rubble emerges a massive creature: Alpha, a mutated monster of enormous size. Its thick skin and rapid regeneration make it almost invulnerable to conventional attacks.");
        Dialog.WriteDialog("Alpha is not alone. It summons smaller creatures to fight by its side, creating a horde that surrounds them. Sean and Helen, exhausted but determined, fight with all their strength.");
        Dialog.WriteDialog("The battle is brutal, but eventually, thanks to Helen's agility and Sean's determination, they manage to bring down Alpha. However, they know that this is not the final enemy. The true challenge is still to come.");
    }

    public static void FinalConfrontationWithColin()
    {
        //! The story when they face Colin, the mastermind behind the nuclear holocaust.

        Dialog.WriteDialog("Finally, after so many trials, Sean and Helen reach Colin's fortress, the man responsible for the nuclear catastrophe that destroyed the world.");
        Dialog.WriteDialog("Colin, the author of the disaster, awaits them. A man with a vision for humanity that led to the creation of mutations and total devastation. His motivation: the belief that humanity needed to be purged to make way for a new era.");
        Dialog.WriteDialog("The final confrontation is inevitable. Filled with rage and sorrow over the loss of his family, Sean knows he must face Colin to put an end to his reign of terror.");
        Dialog.WriteDialog("The fight is fierce, but Sean's willpower drives him to victory. With Colin's fall, the nuclear holocaust finally comes to an end. The world is still devastated, but Sean and Helen know humanity has a chance to rebuild.");
        Dialog.WriteDialog("Though the victory is bittersweet, the two survivors begin to think about the future. Sean's story is far from over, but for now, peace returns to the shattered world.");
    }

}