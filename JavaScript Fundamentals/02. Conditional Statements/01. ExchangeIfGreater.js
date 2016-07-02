function exchangeIfGreater(args) {
	var firstNumber = +args[0],
	 	secondNumber = +args[1],
	 	temp;

	if (firstNumber > secondNumber) {
		temp = firstNumber;
		firstNumber = secondNumber;
		secondNumber = temp;
	}

	return firstNumber + ' ' + secondNumber;
}

console.log(exchangeIfGreater(['5', '2']));
console.log(exchangeIfGreater(['3', '4']));