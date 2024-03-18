const int width = 80;
const int height = 20;

const double step = Math.PI*2 / width;

char[][] fb = new char[height][];

for (int i = 0; i < height; i++)
{
    fb[i] = Enumerable.Repeat(' ', width).ToArray();
}

for (int x = 0; x < width; x++)
{
    int y = (int)(height/2 + Math.Sin(x * step) * (height / 2 - 1));
    fb[y][x] = '*';
}

for (int y = height - 1; y >= 0; y--)
{
    Console.WriteLine(fb[y]);
}