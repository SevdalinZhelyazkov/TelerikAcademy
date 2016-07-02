function sortThreeNumbers(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2],
		result;

	if (a > b) {
		if (b > c) {
			result = a + ' ' + b + ' ' + c;
		}
		else if (a > c) {
			result = a + ' ' + c + ' ' + b;
		}
		else {
			result = c + ' ' + a + ' ' + b;
		}
	}
	else {
		if (a > c) {
			result = b + ' ' + a + ' ' + c;
		}
		else if (b > c) {
			result = b + ' ' + c + ' ' + a;
		}
		else {
			result = c + ' ' + b + ' ' + a;
		}
	}

	return result;
}

console.log(sortThreeNumbers(['5', '1', '2']));
console.log(sortThreeNumbers(['-2', '-2', '1']));