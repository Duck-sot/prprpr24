    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    /*
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

    }*/ 
class GG{

    static int Partition(int[]arr, int low, int high){
        int pivot = arr[high];
        int i = low -1;
        for(int j = low; j<=high-1; j++){
            if(arr[j] < pivot){
                i++;
                Swap(arr,i,j);
            }
        } 
        Swap(arr,i+1,high);
        return i+1;
    }
    static void Swap(int[]arr, int i, int j){
        int tem= arr[i]; 
        arr[i]= arr[j];
        arr[j]= tem; 
    }
    static void QS(int [] arr, int low, int high){
        if(low < high){
            int pi = Partition(arr, low, high);
            QS(arr,low,pi-1);
            QS(arr,pi+1,high);
        }
    }

    static void Selso(int[]arr){
        int n = arr.Length;
        for(int i = 0; i < n -1; i++){
            int min_idx = i ; 
            for(int j = i +1;j<n;j++){
                if(arr[j]<arr[min_idx]){
                    min_idx=j;
                }
            }
            int tem = arr[i];
            arr[i]=arr[min_idx]; 
            arr[min_idx]= tem; 
        }
    }
    static void Ms(int[]arr,int l, int m ,int r){

        int n1 = m-l+1; 
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
    static void Mergesort( int[]arr, int l , int r){
        if(l<r){
            int m = l+(r-l)/2;
            Mergesort(arr,l,m);
            Mergesort(arr, m + 1, r);
            Ms(arr,l,m,r);
        }
    }

    static void Prarr(int[]arr){
        int n = arr.Length;
        for(int i =0; i<n; ++i){
            Console.Write(arr[i]+ " ");
        }
        Console.WriteLine();
    }

    static void Prin(int[]arr){
        foreach(int val in arr)
        Console.Write(val + " ");
        Console.WriteLine();
    }
    public static void Main(string[]args){
        int[] arr= new int[100];
        for(int i = 0; i<arr.Length; i++){
            Random rnd = new Random();
            arr[i] = rnd.Next(1, 10001);
        }
        Stopwatch sw = new Stopwatch();
        sw.Start();
        QS(arr,0,arr.Length-1);
       //Selso(arr);
        sw.Stop();
        Prin(arr);
        TimeSpan ts = sw.Elapsed;
        Console.WriteLine(ts);
    }


}
    /*
 void Main(){
      int[] bb = new int[100000]; 
     for(int i = 0; i < bb.Length; i++){
       Random rnd = new Random();
         bb[i] = rnd.Next(1, 10000);
     }
     Stopwatch sw = new Stopwatch();
     sw.Start();
     mergesort(ref bb);
     sw.Stop();
     TimeSpan ts = sw.Elapsed;

     foreach (int i in bb){
         Console.Write(i + ", ");
     }
    Console.WriteLine(ts);
}

Main();
*/