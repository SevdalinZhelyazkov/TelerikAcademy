// Example input: [ '8', '28 6 21 6 -7856 73 73 -56', '73' ]

function countMatch(args) {
    var i, 
    	count = 0,
    	len = +args[0],
    	myArray = args[1].split(' ').map(Number),
    	target = +args[2];

    for (i = 0; i < len; i += 1) {
    	if (myArray[i] === target) {
    		count += 1;
    	}
    }

    return count;
}

console.log(countMatch([ '8', '28 6 21 6 -7856 73 73 -56', '73' ]));