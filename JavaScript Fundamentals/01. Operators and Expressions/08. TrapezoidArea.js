function trapezoidArea(args) {
	var a = +args[0],
		b = +args[1],
		h = +args[2];

	return ((a + b) * h / 2).toFixed(7);
}

console.log(trapezoidArea(['5', '7', '12']));
console.log(trapezoidArea(['2', '1', '33']));
console.log(trapezoidArea(['8.5', '4.3', '2.7']));