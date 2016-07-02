// Example input: [ '6', '3 4 1 5 2 6' ]

function sortArray(args) {
    var i,
        len = +args[0],
        myArray = args[1].split(' ').map(Number),
        result = '';

    for (i = 0; i < len; i += 1) {
        result = getMaxElement(myArray) + ' ' + result;
    }

    return result.trim();

    function getMaxElement(array, index) {
        var i, len,
            elementIndex,
            index = index || 0,
            maxElement = array[index];

        for (i = index + 1, len = array.length; i < len; i += 1) {
            if (maxElement < array[i]) {
                maxElement = array[i];
                elementIndex = i;
            }
        }

        array.splice(elementIndex, 1);

        return maxElement;
    }
}

console.log(sortArray(['6', '3 4 1 5 2 6']));
