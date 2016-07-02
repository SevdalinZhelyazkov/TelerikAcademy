function isInCircleOutRectangle(args) {
	var x = +args[0],
		y = +args[1],
		radius = 1.5,
		zeroToPoint = (x - 1) * (x - 1) + (y - 1) * (y - 1);
		point = Math.sqrt(zeroToPoint);

	var fromCircle = point <= radius ? 'inside circle' : 'outside circle';
	var fromRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1) ? 'inside rectangle' : 'outside rectangle';
	
	return fromCircle + ' ' + fromRectangle;
}

console.log(isInCircleOutRectangle(['2.5', '2']));
console.log(isInCircleOutRectangle(['0', '1']));
console.log(isInCircleOutRectangle(['1', '2']));