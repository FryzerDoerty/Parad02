﻿//Структурное программирование:
//__
//Трассировка пути в лабиринте:
//__
//Описание: Имеется двумерный массив, представляющий лабиринт, где '0' - это проход, а '1' - это стена. Начальная и конечная точки заданы. Необходимо определить путь от начальной до конечной точки.
//Почему это структурное программирование: Задача может быть решена с помощью последовательных шагов, ветвлений (проверка на наличие стены или уже посещенной клетки) и циклов (для обработки всех возможных направлений движения).
void Main(){
int[,] array = new int[3,4]{
    {0,0,1,0}, 
    {1,0,0,1},
    {1,0,0,0}
};
for(int i=0; i<array.GetLength(0);i++){
    for(int j=0; j<array.GetLength(1);j++){ 
        if(array[i,j]==0){
            
            System.Console.WriteLine("["+i+","+j+"]");
            //j++;
        }
        else{
            j--;
            i++;
            System.Console.WriteLine("["+i+","+j+"]");
        }
}
}}
Main();