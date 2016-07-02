function multiplicationSign(args) {
	var firstNumber = +args[0],
		secondNumber = +args[1],
		thirdNumber = +args[2],
		result;

	if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
		result = 0;
	}
	else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) {
		result = '+';
	}
	else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) {
		result = '+';
	}
	else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) {
		result = '+';
	}
	else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) {
		result = '+';
	}
	else {
		result = '-';
	}

	return result;
}

console.log(multiplicationSign(['5', '2', '2']));
console.log(multiplicationSign(['-2', '-2', '1']));
console.log(multiplicationSign(['-2', '4', '3']));