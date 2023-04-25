int[,] pic = new int[23,25];
//x,y
//x-1, y = вверх /1
//x+1, y = вниз /2
//x, y-1 = влево /3
//x, y+1 = вправо /4

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength; i++)
    {
     for (int j = 0; j < image.GetLength; j++)
     {
        //Console.WriteLine($"{imagen[i,j]} ");
        if (image[i,j] == 0) Console.Write($" ");
        else Console.Write($"+");
     }
    Console.WriteLine();   
    }
}
void FillImage(int row, int col)
{
    if (pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
