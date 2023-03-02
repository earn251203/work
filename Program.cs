 class Program{

    static void Main(string[] args) {
        Console.Write(" Password :");
        int y = int.Parse(Console.ReadLine());
        
        Console.Write(" company :");
        string z = (Console.ReadLine());

        if( y <= 999999 && y >= 0) {
            int a = y / 100000 % 10;  
            int b = y / 10000 % 10;
            int c = y / 1000 % 10;
            int d = y / 100 % 10;
            int e = y / 10 % 10;
            int g = y % 10;
        
        if(z == "CIA") {
            if((c >= 6 && c != 8) && (e != 3 && e != 5) && (g % 3 == 0)) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
        else if(z == "FBI") {
            if((a >= 4 && a <=7) && (d % 2 == 0 && d != 6) && (b % 2 != 0)) {
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else if(z == "NSA") {
            if((d % 3 == 0 && d % 2 != 0) && (g == 1 || g == 2 || g == 3 || g == 5 || g == 6) && (a == 7 || b == 7 || c == 7 || d == 7 || e == 7 || g == 7)) {
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
    }
}
}