function calcAreaAndPerimeter(args) {
	var width = +args[0],
		height = +args[1],
		perimeter = (2 * (width + height)),
		area = (width * height);
	return area.toFixed(2) + ' ' + perimeter.toFixed(2);
}

console.log(calcAreaAndPerimeter([ '5', '5' ]));
console.log(calcAreaAndPerimeter([ '3', '4' ]));