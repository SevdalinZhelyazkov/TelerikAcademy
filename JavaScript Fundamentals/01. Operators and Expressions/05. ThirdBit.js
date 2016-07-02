function getThirdBit(args) {
	var number = +args[0],
		mask = 1,
		thirdBit = number & (mask << 3);
	return thirdBit === 0 ? 0 : 1;
}

console.log(getThirdBit(['15']));
console.log(getThirdBit(['1024']));