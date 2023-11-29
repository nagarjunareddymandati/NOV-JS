const arr = [1, 2, 3, 4, 5, 6];
console.log(arr.reverse());
console.log(reverseArray(arr, 0, arr.length - 1))
function reverseArray (arr, start, end ) {
    if(start > end) {
        return;
    }
    let temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;
    reverseArray(arr, start+1, end-1);
    return arr;
}

