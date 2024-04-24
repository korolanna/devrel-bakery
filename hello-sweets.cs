//This is a function that combines a very special treat. Learn about a new type of croissant.
public static void HelloSweets()
    {
      String sweets = "croissants, cinnamon rolls, & donuts ";
      Console.WriteLine("I love '{0}'", sweets, '!');
      String sweetsPlus = sweets.Insert(4, "cookie");
      Console.WriteLine("But have you heard of: '{0}'", sweetsPlus, '!');
 }

 public static int TeamDevRel(int A, int T, int P, int V, int L) 
  { 
    // Each letter corresponds to a team member's name. 
    // A for Anna. T for Tao. P for Patrick. V for Valeria. L for Lily. 
    // This functions shows numerically how each member is the sum of our whole team.
      int sum = A + T + P + V + L; 
      return sum; 
      }