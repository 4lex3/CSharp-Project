public class BattleController
{

    private Player player;
    private Helen helen;
    private Sean sean;
    private bool alliesTurn = true;


    public BattleController(Player player, Helen helen, Sean sean)
    {
        this.player = player;
        this.helen = helen;
        this.sean = sean;
    }

    public void StartBattle(Enemy enemy)
    {

        List<string> attackLog = new List<string>();
        player.AddNewAttempt();

        sean.Health = 100;
        helen.Health = 100;
        enemy.Health = 100;


        while (sean.Health > 0 && helen.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();

            BattleUI.PlayerStatusBar(helen, sean, enemy);
            BattleUI.AttackLogBar(attackLog);


            if (alliesTurn)
            {

                AttackInfo helenAttack = helen.Attack(enemy);
                attackLog.Add(helenAttack.attackLog);

                AttackInfo seanAttack = sean.Attack(enemy);
                attackLog.Add(seanAttack.attackLog);

                alliesTurn = false;

            }
            else
            {
                attackLog.Add(ExecuteEnemyAttack(enemy).attackLog);
                alliesTurn = true;
            }
        }


        Console.Clear();
        BattleUI.PlayerStatusBar(helen, sean, enemy);

        if (enemy.Health <= 0)
        {
           
            enemy.MarkAsDefeated();
            player.UpLevel();
            BattleUI.VictoryMessage();

            
        }
        else
        {

            Console.WriteLine($"Recuerda que el objetivo es que Helen y tu lleguen con vida hasta el final!");
            
            BattleUI.GameOverMessage();
        }

        BattleUI.PlayerStatsTable(player);

    }

    private AttackInfo ExecuteEnemyAttack(Enemy enemy)
    {

        if (enemy.AttackOnSean())
        {
            return enemy.Attack(sean);
        }

        return enemy.Attack(helen);
    }

    


}