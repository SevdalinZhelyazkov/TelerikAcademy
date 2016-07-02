function isDivisibleBy7and5(args) {
	var input = +args[0];
	if (input % 7 || input % 5) {
		return 'false ' + input;
	}
	return 'true ' + input;
}

console.log(isDivisibleBy7and5(['21']));
console.log(isDivisibleBy7and5(['35']));