using Snake.BackgroundAggregate;
using Snake.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snakes
    {
        public Pixel Head { get; set; }

        public Queue<Pixel> Body = new Queue<Pixel>();
        private const ConsoleColor _headColor = ConsoleColor.Green;
        private const ConsoleColor _bodyColor = ConsoleColor.Yellow;
        private int _bodyLength = 3;
       
        public Snakes()
        {
            Head = new Pixel(15, 5, _headColor);
            for (int i = _bodyLength; i >=0; i--)
            {
                Body.Enqueue(new Pixel(Head.X - i - 1, 5, _bodyColor));
            }
            DrawSnake();
        }
        public void DrawSnake()
        {
            Head.DrawPixel();
            foreach (var pix in Body)
            {
                pix.DrawPixel();
            }
        }
        public void Clear()
        {
            Head.Clear();
            foreach (var pix in Body)
            {
                pix.Clear();
            }
        }

        public void Move(Direction dir, bool eat = false)
        {
            Clear();
            Body.Enqueue(new Pixel(Head.X, Head.Y,_headColor));
            if (eat)
                Body.Dequeue();
            Head = dir switch
            {
                Direction.Up => new Pixel(Head.X, Head.Y - 1,_headColor),
                Direction.Down => new Pixel(Head.X, Head.Y + 1, _headColor),
                Direction.Right => new Pixel(Head.X + 1, Head.Y, _headColor),
                Direction.Left => new Pixel(Head.X - 1, Head.Y, _headColor),
                _ => Head
            };
            DrawSnake();
        }
    }
}
