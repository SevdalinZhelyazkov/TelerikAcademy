// Example input: [ '8\n7\n3\n2\n3\n4\n2\n2\n4' ]

function maxIncreasingSequence(args) {
	var i,
		len,
		count = 1,
		maxLength = 0,
		myArray = args[0].split('\n').map(Number);

	for (i = 1, len = myArray.length; i < len - 1; i += 1) {
		if (myArray[i] < myArray[i + 1]) {
			count += 1;
			if (maxLength < count) {
				maxLength = count;
			}
		} else {
			count = 1;
		}
	}

	return maxLength;
}

console.log(maxIncreasingSequence(['8\n7\n3\n2\n3\n4\n2\n2\n4']));