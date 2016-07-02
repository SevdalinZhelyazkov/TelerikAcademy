// Example input: [ '13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3' ]

function mostFrequentNumber(args) {
    var i,
        j,
        index,
        count = 1,
        maxCount = 0,
        myArray = args[0].split('\n').map(Number),
        len = myArray.length;

    for (i = 1; i < len - 1; i += 1) {
        for (j = i + 1; j < len; j += 1) {
            if (myArray[i] == myArray[j]) {
                count += 1;
            }
        }
        if (maxCount < count) {
            maxCount = count;
            index = i;
        }
        count = 1;
    }

    return myArray[index] + ' (' + maxCount + ' times)';
}

console.log(mostFrequentNumber(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']));