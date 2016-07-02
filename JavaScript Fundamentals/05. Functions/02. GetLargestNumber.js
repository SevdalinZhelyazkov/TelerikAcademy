// Example input: ['8 3 6']

function getMax(args) {
    var i, len,
    	numbers = args[0].split(' ').map(Number),
    	max = numbers[0];

    for (i = 1, len = numbers.length; i < len; i += 1) {
    	if (numbers[i] > max) {
    		max = numbers[i];
    	}
    }

    return max;
}

console.log(getMax(['8 3 6']));