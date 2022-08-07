Console.Clear();
void FILLArray(int[] collection){
    int leght = collection.Length;
    int index = 0;
    while(index< leght){
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int [] collection,  int find){
    int count = collection.Length;
    int index = 0;
    int position= 0;
    while( index < count){
        if(collection[index] == find){
                position = index;
                break;
                
        }
        else{
            position = -1;
        }
        
        index++;
    }
    return position;
}
int [] MyArray = new int [10];
FILLArray(MyArray);
PrintArray(MyArray);
System.Console.WriteLine();

int pos = IndexOf(MyArray,4);
System.Console.WriteLine(pos);