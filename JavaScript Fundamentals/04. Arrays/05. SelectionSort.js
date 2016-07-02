// Example input: [ '6\n3\n4\n1\n5\n2\n6' ]

function selectionSort(args) {
    var i,
        j,
        temp,
        minElement,
        result = '',
        myArray = args[0].split('\n').map(Number),
        len = myArray.length;

    for (i = 1; i < len - 1; i += 1) {
        minElement = i;

        for (j = i + 1; j < len; j += 1) {
            if (myArray[j] < myArray[minElement]) {
                minElement = j;
            }
        }

        if (minElement != i) {
            temp = myArray[i];
            myArray[i] = myArray[minElement];
            myArray[minElement] = temp;
        }
    }

    for (i = 1; i < len; i += 1) {
        result += myArray[i] + '\n';
    }

    return result;
}

console.log(selectionSort(['6\n3\n4\n1\n5\n2\n6']));