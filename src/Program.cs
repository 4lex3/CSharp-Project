class Program
{
    static void Main()
    {

        SessionController sessionController = new SessionController();
        Player player = new Player(0, "", 0, 0, 0, DateTime.Now, false);
        Map map = new Map(new List<Enemy> {
            new Spider(), new Common(), new ShadowHunter(), new Common(), new Alpha(), new Colin()
        });
        Helen helen = new Helen(
            new List<Ability> { new BasicHelen(), new SpecialHelen(), new UltimateHelen() }, "Helen"
        );
        Sean sean = new Sean(
            new List<AbilityWithCost> { new BasicSean(), new SpecialSean(), new UltimateSean() },
            "Sean",
            new EnergyController()
        );




        Game game = new Game(
            player, sessionController, map, helen, sean, new BattleController(player, helen, sean)
        );

        game.Start();



    }

    /*

        *TODO: Arreglar lucky shot 
        ?TODO: Arreglar los puntos de energia por dano

        *TODO: Arreglar bucle de gameover
        TODO: Hacer cargado de partida 
        TODO: Guardar partida

    */

}
