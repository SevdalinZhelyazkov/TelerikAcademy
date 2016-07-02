function matchThirdDigit(args) {
	var number = +args[0],
		thirdDigit = ((number / 100) | 0) % 10;

	if (thirdDigit === 7) {
		return 'true';
	}
	
	return 'false ' + thirdDigit;
}

console.log(matchThirdDigit(['5']));
console.log(matchThirdDigit(['701']));
console.log(matchThirdDigit(['801']));
console.log(matchThirdDigit(['9703']));