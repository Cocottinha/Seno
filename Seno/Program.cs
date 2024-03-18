const uint width = 40;
const uint height = 10;

const double step = Math.PI / 2 / width;

string[] lines = new string[height];

for (int y = (int)height - 1; y >= 0; y--)
{

}






for (int x = 0; x < width / 2; x++)
{
    uint y = Convert.ToUInt32(Math.Sin(step * x) * height);
    char[] line = new char[width];
    for (int x2 = 0; x2 < x; x2++ )
    {
        line[x2] = ' ';
    }
    line[x] = '*';
    for (int x3 = x; x3 < width / 2; x3++)
    {
        line[x3] = ' ';
    }
}