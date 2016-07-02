function isPrime(args) {
	var number = +args[0],
		divider = 2;

	if (number <= 1) return false;
	if (number === 2) return true;
	for (var i = divider; i <= Math.sqrt(number); i++) {
		if (number % i === 0) {
			return false;
		}
	}
	return true;
}

console.log(isPrime(['23']));
console.log(isPrime(['25']));