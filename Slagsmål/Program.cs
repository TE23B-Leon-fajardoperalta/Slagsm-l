
int op = 100;
int dop = 100;

// hp på båda gubbarna jag har planerat 


// ska spelas så länge deras inte är 0
// hade tänkt att döda båda om en dör 
while (dop != 0 && op != 0 )
{


    int num = Random.Shared.Next(1, 11);
    dop = dop - num;

    num = Random.Shared.Next(1, 11);
    op = op - num;

   Console.WriteLine(dop);
   
   Console.WriteLine(op);

   if (op <= 0 && op < dop)
   {
    op = 0;
    Console.WriteLine("opp förlora");
   }
   
   if (dop <= 0 && dop < op)
   {
    Console.WriteLine("dopp förlora");
    dop = 0;
   }
   

   Console.ReadLine();

}

   if (op == 0 && op == 0)
   {
    Console.WriteLine("oavgjort");
   }
