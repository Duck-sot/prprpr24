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
static void MS(ref int[]arr,int l, int m ,int r){
    int n1 = m-1+1; 
    int n2 = r-m;
    int[] L = new int[n1];
    int[] R = new int[n2];
    int i , j; 

    for(i=0; i<n1; ++i)
        L[i]= arr[l+i];
    for(j = 0; j < n2; ++j)
        R[j] = arr[m+1+j]; 

    i = 0; 
    j = 0; 

    int k =l; 
    while(i <n1 && j < n2){
        if(L[i] <= R[j]){
            arr[k]= L[i];
            i++;
        }
        else{
            arr[k]= R[j];
            j++;
        }
        k++;
    }
    while(i < n1){
        arr[k] = L[i];
        i++;
        k++;
    }
    while(j<n2){
        arr[k]=R[j];
        j++;
        k++;
    }
}
static void mergesort(int[]arr)

void Main(){
    int[] bb = new int[100000]; 
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