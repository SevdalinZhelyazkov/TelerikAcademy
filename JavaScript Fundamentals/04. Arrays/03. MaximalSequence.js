// Example input: [ '10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1' ]

function findMaxSequence(args) {
    var i,
        len,
        currentLength = 1,
        maxLength = 0,
        myArray = args[0].split('\n').map(Number);

    for (i = 1, len = myArray.length; i < len - 1; i += 1) {
        if (myArray[i] == myArray[i + 1]) {
            currentLength += 1;
            if (maxLength < currentLength) {
                maxLength = currentLength;
            }
        } else {
            currentLength = 1;
        }
    }

    return maxLength;
}

console.log(findMaxSequence(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']));