// Создать двумерный массив и поменять любые две строки местами.
/*
int[,] CreateRandom2dArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
void ChangeRows(int row1, int row2, int[,] array)
{
  if(row1 >=0 && row1 < array.GetLength(0) && row2 >=0 && row2 <    array.GetLength(0) && row1 != row2)
    
      for(int j = 0; j < array.GetLength(1); j++)
      {
        int temp = array[row1,j];
        array[row1,j] = array[row2,j];
        array[row2,j] = temp;
      }
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int [,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);

Console.Write("Input a number of the first row for changing: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row for changing: ");
int row2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(row1,row2, newArray);
Show2dArray(newArray);
*/
//=============================================================
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] CreateRandom2dArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
void MatrixReversal (int[,] array) 
{
  if(array.GetLength(0)==array.GetLength(1))
    for(int i =0; i < array.GetLength(0); i++)
      for(int j = i+1; j < array.GetLength(1); j++)
      {
        int temp =array[i,j];
        array[i,j] = array[j,i];
        array[j,i] =temp;
      }
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
MatrixReversal(newArray);
Show2dArray(newArray);
*/
//===========================================================
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых находится наименьший элемент.
/*
int[,] CreateRandom2dArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
int [] MinNumArray (int[,] array) 
{
  int minI = 0;
  int minJ = 0;
  for(int i =0; i < array.GetLength(0); i++)
    for(int j = i+1; j < array.GetLength(1); j++)
    {
      if(array[i,j] < array[minI,minJ])
      {
        minI = i;
        minJ = j;
      }
    }
  int[]pos = {minI, minJ};
  return pos; 
}
int [,] DeleteRowColumnMinElement(int[,]array, int[] pos)
{
  int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
  for(int i =0, x = 0; i < array.GetLength(0); i++)
  {
      if(i != pos[0])
      {
        for(int j = 0, y = 0; j < array.GetLength(1); j++)
        {
          if(j != pos[1])
          {
              newArray[x,y] =array[i,j];
              y++;
          }
        }
        x++;
      }
  }
  return newArray;
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
int [] pos = MinNumArray(newArray);
int[,] matrix = DeleteRowColumnMinElement(newArray, pos);
Show2dArray(matrix);
*/