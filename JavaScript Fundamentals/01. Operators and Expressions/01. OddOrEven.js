function oddOrEven(args) {
    var input = +args[0];
    if (input % 2) {
        return 'odd ' + input;
    }
    return 'even ' + input;
}

console.log(oddOrEven(['123']));
console.log(oddOrEven(['124']));