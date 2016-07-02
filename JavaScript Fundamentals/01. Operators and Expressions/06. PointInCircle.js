function isInCircle(args) {
	var x = +args[0],
		y = +args[1],
		radius = 2,
		zeroToPoint = x * x + y * y;
		point = Math.sqrt(zeroToPoint);

	return (point <= radius ? 'yes ' + point.toFixed(2) : 'no ' + point.toFixed(2));
}

console.log(isInCircle(['-2', '0']));
console.log(isInCircle(['-1', '2']));