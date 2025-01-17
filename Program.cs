using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

void BS(ref int[]arr ){
    for(int b = 0; b< arr.Length - 1;b++){
        
        for(int s =0; s < arr.Length - b - 1; s++){
            if(arr[s] > arr[s+1]){
                int tem = arr[s];
                arr[s]=arr[s +1];
                arr[s + 1] = tem;
            }
        }
    } 

} 

void Main(){
    int[] bb = new int[1000]; 
    for(int i = 0; i < bb.Length; i++){
        Random rnd = new Random();
        bb[i] = rnd.Next(1, 10000);
    }
    Stopwatch sw = new Stopwatch();
    sw.Start();
    BS(ref bb);
    sw.Stop();
    TimeSpan ts = sw.Elapsed;

    foreach (int i in bb){
        Console.Write(i + ", ");
    }
    Console.WriteLine(ts);
}

Main();