 int []array = {23,14,3,58,95,12,3,90};
 int n = array.Length;
 int find = 3;
 int index = 0;
 while(index < n)
 {
    if(array[index]== find){
        Console.WriteLine(index);
        break;
    }
     index ++ ;
 }
 
