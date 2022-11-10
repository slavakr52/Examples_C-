int count = 0;
int first_friend_speed = 2;
int second_friend_speed = 2;
int dogspeed = 20;
int distance = 10000;
int friend = 2;
int time = 0;
while (distance > 100)
{
    if (friend == 1)
    {
        time = distance / (first_friend_speed + dogspeed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        friend = 2;
        count++;
    }
    if (friend == 2)
    {
        time = distance / (second_friend_speed + dogspeed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        friend = 1;
        count++;
    }
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз");