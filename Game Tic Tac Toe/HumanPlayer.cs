public class HumanPlayer : Player
{
    public HumanPlayer(string name, char symbol) : base(name, symbol) { }

   public override void MakeMove(Board board)
   {
      while (true)
      {
        try
        {
            Console.Write($"{Name} ({Symbol}), Nhap hang (0-2): ");
            string? inputRow = Console.ReadLine();

            Console.Write($"{Name} ({Symbol}), Nhap cot (0-2): ");
            string? inputCol = Console.ReadLine();

            if (int.TryParse(inputRow, out int row) && int.TryParse(inputCol, out int col))
            {
                if (!board.PlaceMove(row, col, Symbol))
                {
                    Console.WriteLine("O da dc danh !!");
                }
                else
                {
                    break; 
                }
            }
            else
            {
                Console.WriteLine("Du lieu khong hop  le. Nhap tu so 0 den 2.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi. Vui long nhap lai.");
        }
      }
   }
}
   




