// Example input: ['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']

function binarySearch(args) {
    var middle,
        myArray = args[0].split('\n').map(Number),
        target = myArray.pop(1),
        end = myArray.shift(1) - 1,
        start = 0;

    myArray.sort(function(a, b) {
        return a - b;
    });

    while (start <= end) {
        middle = ((start + end) / 2) | 0;
        if (target < myArray[middle]) {
            end = middle - 1;
        } else if (target > myArray[middle]) {
            start = middle + 1;
        } else {
            return middle;
        }
    }

    return -1;
}

console.log(binarySearch(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']));