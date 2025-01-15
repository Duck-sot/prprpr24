using System.ComponentModel;
using System.Globalization;

static void QS(int[]arr, int n){
    int q, s , tem;
    bool qsed;
    for(q = 0; q< n-1;q++){
        qsed = false;
        for(s=0; s < n; s++){
            if(arr[s] > arr[s+1]){
                tem = arr[s];
                arr[s]=arr[s +1];
                arr[s + 1] = tem;
                qsed = true; 
            }
        }
        if(qsed = false){
            break;
        }
    } 

} 