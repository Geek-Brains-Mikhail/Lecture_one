int[] array = {11,2,4,123,443,5,6,72,4,8};

int n = array.Length;
int find =4;

int index = 0;

while(index < n){
    if ( array[index] == find){
        Console.WriteLine(index);
    }
    index++;
}