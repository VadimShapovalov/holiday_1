//Реализовать игру "Камень, ножницы, бумага. Игра может продолжаться несколько раундов.
//Каждый раунд начисляются очки победителю.
int score = 0;
int score2 = 0;
while(score < 3 && score2 < 3)
{
    Console.WriteLine("Напишите цифру соответвующую Вашему выбору ");
    Console.WriteLine("1 - камень, 2 - ножницы, 3 - бумага");
    int player = Convert.ToInt32(Console.ReadLine());
    Random num = new Random();
    int player2 = num.Next(1, 4);

    if(player == player2)
    {
        Console.WriteLine("Ничья. У обоих игроков одинаковый выбор.");
    }
    if(player == 1 && player2 == 2)
    {
        Console.WriteLine("Вы выбрали камень и выиграли! Камень бьет ножницы.");
        score ++;
    }
    if(player == 1 && player2 == 3)
    {
        Console.WriteLine("Вы выбрали камень и проиграли! Бумага бьет камень.");
        score2 ++;
    }
    if(player == 2 && player2 == 1)
    {
        Console.WriteLine("Вы выбрали ножницы и проиграли! Камень бьет ножницы.");
        score2 ++;
    }
    if(player == 2 && player2 == 3)
    {
        Console.WriteLine("Вы выбрали ножницы и выиграли! Ножницы бьют бумагу.");
        score ++;
    }
    if(player == 3 && player2 == 1)
    {
        Console.WriteLine("Вы выбрали бумагу и выиграли! Бумага бьет камень.");
        score ++;
    }
    if(player == 3 && player2 == 2)
    {
        Console.WriteLine("Вы выбрали бумагу и проиграли! Ножницы бьют бумагу.");
        score2 ++;
    }
}
if(score > score2)
{
    //Console.WriteLine("Конец игры. Вы победитель!");
    Console.WriteLine($"Конец игры. Вы победитель! Окончательный счет: Вы набрали {score} балла. Второй игрок набрал {score2} балла");
}
else
{
    //Console.WriteLine("Конец игры. Вы проиграли.");
    Console.WriteLine($"Конец игры. Вы проиграли! Окончательный счет: Вы набрали {score} балла. Второй игрок набрал {score2} балла");
}


