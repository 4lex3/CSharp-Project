public class HistoryUI
{

    private static void PressAnyKey()
    {
        Dialog.WriteDialog("\n\n\n\nPress any key to continue...", ConsoleColor.Yellow);
        Console.ReadKey();
        
    }

    public static void StartStory()
    {
        Console.Clear();
        
        Dialog.WriteDialog("The world is no longer what it once was. A nuclear holocaust wiped out humanity, leaving only ruins and despair in its wake. Sean, a young survivor, lost his parents to mutations caused by the radiation. His mission is simple: survive and find out who caused this disaster.", ConsoleColor.Magenta);
        Dialog.WriteDialog("By his side is Helen, a thief with a mysterious past. Though her loyalty is uncertain, both know that cooperation is the only way to have a chance at surviving in this destroyed world.", ConsoleColor.Magenta);
        Dialog.WriteDialog("Together, they journey through the wasteland, hoping to find answers and a way to move forward. But danger lurks around every corner...", ConsoleColor.Magenta);

        PressAnyKey();
    }

    private static void EncounterWithSpider()
    {

        Console.Clear();
        Dialog.WriteDialog("After several days of traveling through a ruined desert, Sean and Helen come across something strange: a thick web covering the ruins of an old city.");
        Dialog.WriteDialog("From the shadows emerge massive mutated spiders, known as Spiders. Their eyes glow like beacons in the darkness, and their sharp legs click as they move.");
        Dialog.WriteDialog("Sean and Helen fight with everything they have. The Spiders strike fast, trying to trap them in their sticky webs. But with agility and cunning, they manage to escape, though the battle leaves a mark: the world is full of monsters, and survival will only get harder.");

        PressAnyKey();
    }

    private static void EncounterWithShadowHunter()
    {

        Console.Clear();
        Dialog.WriteDialog("Night falls quickly as they move through a city even darker, surrounded by towering buildings blocking out the little remaining light.");
        Dialog.WriteDialog("The air grows thick, and something seems to move in the shadows. Sean senses a strange presence, something ominous. Suddenly, they appear: the Shadow Hunters, mutant creatures that only move in the dark.");
        Dialog.WriteDialog("The fight begins. The Shadow Hunters are fast and nearly invisible, moving silently through the shadows. Sean and Helen, unable to see them fully, use the light from a lantern to reveal the creatures.");
        Dialog.WriteDialog("The battle is intense, but with cleverness and teamwork, they manage to defeat the hunters. However, they know the danger is far from over.");

        PressAnyKey();
    }

    private static void EncounterWithAlpha()
    {

        Console.Clear();
        Dialog.WriteDialog("The journey continues, but fear lingers. After days of constant battles, Sean and Helen arrive at a zone completely devastated by a previous fight. The ruins of a forgotten war give way to a new threat.");
        Dialog.WriteDialog("From the rubble emerges a massive creature: Alpha, a mutated monster of enormous size. Its thick skin and rapid regeneration make it almost invulnerable to conventional attacks.");
        Dialog.WriteDialog("Alpha is not alone. It summons smaller creatures to fight by its side, creating a horde that surrounds them. Sean and Helen, exhausted but determined, fight with all their strength.");
        Dialog.WriteDialog("The battle is brutal, but eventually, thanks to Helen's agility and Sean's determination, they manage to bring down Alpha. However, they know that this is not the final enemy. The true challenge is still to come.");

        PressAnyKey();
    }

    private static void FinalConfrontationWithColin()
    {
        Console.Clear();
        Dialog.WriteDialog("Finally, after so many trials, Sean and Helen reach Colin's fortress, the man responsible for the nuclear catastrophe that destroyed the world.");
        Dialog.WriteDialog("Colin, the author of the disaster, awaits them. A man with a vision for humanity that led to the creation of mutations and total devastation. His motivation: the belief that humanity needed to be purged to make way for a new era.");
        Dialog.WriteDialog("The final confrontation is inevitable. Filled with rage and sorrow over the loss of his family, Sean knows he must face Colin to put an end to his reign of terror.");
        Dialog.WriteDialog("The fight is fierce, but Sean's willpower drives him to victory. With Colin's fall, the nuclear holocaust finally comes to an end. The world is still devastated, but Sean and Helen know humanity has a chance to rebuild.");
        Dialog.WriteDialog("Though the victory is bittersweet, the two survivors begin to think about the future. Sean's story is far from over, but for now, peace returns to the shattered world.");

        PressAnyKey();
    }

    public static void ShowHistoryByEnemy(Enemy enemy)
    {

        switch (enemy.CharacterName)
        {
            case "Spider":
                EncounterWithSpider();
                break;

            case "Shadow Hunter":
                EncounterWithShadowHunter();
                break;

            case "Alpha":
                EncounterWithAlpha();
                break;

            case "Colin":
                FinalConfrontationWithColin();
                break;
        }
    }

}