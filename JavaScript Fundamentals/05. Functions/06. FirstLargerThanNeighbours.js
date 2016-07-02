// Example input: [ '6', '-26 -25 -28 31 2 27' ]

function firstLargerThanNeighbours(args) {
    var i, 
    	count = 0,
    	len = +args[0],
    	myArray = args[1].split(' ').map(Number);

    for (i = 1; i < len - 1; i += 1) {
    	if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1]) {
    		return i;
    	}
    }

    return -1;
}

console.log(firstLargerThanNeighbours([ '6', '-26 -25 -28 31 2 27' ]));