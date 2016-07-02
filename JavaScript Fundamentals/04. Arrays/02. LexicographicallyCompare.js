// Example input: [ 'hello\nhalo' ]

function compareStrings(args) {
	var i,
		minLength,
		stringArray = args[0].split('\n'),
		firstString = stringArray[0],
		secondString = stringArray[1];

	minLength = Math.min(firstString.length, secondString.length);

	for (i = 0; i < minLength; i += 1) {
		if (firstString[i] < secondString[i]) {
			return '<';
		}
		if (firstString[i] > secondString[i]) {
			return '>';
		}
	}

	if (firstString.length < secondString.length) {
		return '<';
	}
	if (firstString.length > secondString.length) {
		return '>';
	}

	return '=';
}

console.log(compareStrings([ 'hello\nhalo' ]));
console.log(compareStrings(['food\nfood']));