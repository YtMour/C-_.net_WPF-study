


namespace Bulls_and_Cows;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">> YT numb play");
        Console.WriteLine("");
        Console.Write("请输入猜数范围的最大值和最小值,(0,100) : ");
        string input = Console.ReadLine();
        //随机数创建
        Console.WriteLine("");
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("数据格式不对,请检查");
        }
        else
        {
            string[] range = input.Split(',');
            if (range.Length != 2)
            {
                Console.WriteLine("数据格式不对,请检查");
            }
            else
            {
                if (!int.TryParse(range[0], out int min) || !int.TryParse(range[1], out int max))
                {
                    Console.WriteLine("数据格式不对,请检查");
                }
                else
                {
                    if (min > max)
                    {
                        int temp = min;
                        min = max;
                        max = temp;
                    }
                    int target = new Random().Next(min, max);
                    int? guess = null;
                    //开始循环
                    do
                    {
                        Console.Write(">> 请输入数字: ");
                        //接受用户输入
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int guesstest))
                            guess = guesstest;
                        if (guess == null)
                        {
                            Console.WriteLine("输入的猜测数字有问题");
                            continue;
                        }
                        //开始比较
                        if (guess == target)
                        {
                            Console.WriteLine("恭喜猜中了~！~");
                        }
                        else
                        {
                            if (guess < target)
                            {
                                Console.WriteLine("猜小了");

                            }
                            if (guess > target)
                            {
                                Console.WriteLine("猜大了");

                            }
                        }

                    } while (guess != target);
                }
            }
        }
    }
}
