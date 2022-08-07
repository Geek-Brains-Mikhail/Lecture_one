int Findind(int [] Array, int find){
    int score = 0;
    int result = 0;
    while(score < Array.Length){
        if (Array[score] == find){
            result = score;
            break;
            
        }
        else{
            result = -1;
        }
        score++;
    }
    return result;
}

int[] array = {12,22,33,43,35,67,37,81,39};
int find =37;
int index = Findind(array,find);
Console.WriteLine("Индекс схожего элемента = " + index);

