void Fillnumber3(int number ) {
    int resualt = number%1000;
    if (resualt>=100) {
        int final = number%10;
        Console.WriteLine(final);
    }
    else {
        Console.WriteLine("Нет третьего числа");
    }
    }

int numberA=int.Parse(Console.ReadLine());
Fillnumber3(numberA);

