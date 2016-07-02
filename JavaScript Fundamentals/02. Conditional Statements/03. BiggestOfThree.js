function biggestOfThree(args) {
	var firstNumber = +args[0],
		secondNumber = +args[1],
		thirdNumber = +args[2],
		result;

	if (firstNumber > secondNumber) {
		if (secondNumber > thirdNumber || firstNumber > thirdNumber) {
			result = firstNumber;
		}
		else {
			result = thirdNumber;
		}
	}
	else {
		if (firstNumber > thirdNumber || secondNumber > thirdNumber) {
			result = secondNumber;
		}
		else {
			result = thirdNumber;
		}
	}

	return result;
}

console.log(biggestOfThree(['5', '2', '2']));
console.log(biggestOfThree(['-2', '-2', '1']));