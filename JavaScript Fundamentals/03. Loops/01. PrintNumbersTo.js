function printNumbersTo(args) {
    var i,
    	n = +args[0],
        result = '';

    for (i = 1; i <= n; i++) {
        result += ' ' + i;
    }

    return result;
}

console.log(printNumbersTo(['5']));