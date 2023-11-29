const pair = (arr, len) => {
    i = 0;
    sum = 0;
    while(i < len - 1) {
        if(arr[i] != arr[i + 1]){
            sum += 1;
            i+= 2;
        } else {
            i++;
        }
        
    }
    return sum;
}

console.log(pair([1,2,3,4,5], 5));