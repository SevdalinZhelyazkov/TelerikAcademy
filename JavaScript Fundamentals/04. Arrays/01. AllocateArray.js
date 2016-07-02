function allocateArray(args) {
	var i,
		myArray = [],
		result = '',
		arraySize = +args[0];

	for (i = 0; i < arraySize; i += 1) {
		myArray[i] = i * 5;
		result += myArray[i] + '\n';
	}
	
	return result;
}

console.log(increaseMembers(['5']));