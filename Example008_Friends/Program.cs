int count = 0;
int distance = 10000;
int first_friend_speed = 3;
int second_friend_speed = 4;
int dogspeed = 7;
int friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        int time = distance / (first_friend_speed + dogspeed);
        friend = 2;
    }
    if (friend == 2)
    {
        int time = distance / (second_friend_speed + dogspeed);
        friend = 1;
    }

    int distance = distance - (first_friend_speed + second_friend_speed) * time;
    count = count + 1;
}
Console.Write("Собака пробежала");
Console.Write(count);
Console.Write("раз");